using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121A RID: 4634
	[NetMessage(EMessageId.SettingNotify)]
	public sealed class SettingNotify : IMessage<SettingNotify>, IMessage, IEquatable<SettingNotify>, IDeepCloneable<SettingNotify>, IBufferMessage
	{
		// Token: 0x06018BEB RID: 101355 RVA: 0x0039B301 File Offset: 0x00399501
		[NullableContext(1)]
		public static SettingNotify Create()
		{
			return new SettingNotify();
		}

		// Token: 0x17005388 RID: 21384
		// (get) Token: 0x06018BEC RID: 101356 RVA: 0x0039B308 File Offset: 0x00399508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005389 RID: 21385
		// (get) Token: 0x06018BED RID: 101357 RVA: 0x0039B30B File Offset: 0x0039950B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettingNotify.Descriptor;
			}
		}

		// Token: 0x06018BEE RID: 101358 RVA: 0x0039B312 File Offset: 0x00399512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingNotify()
		{
		}

		// Token: 0x06018BEF RID: 101359 RVA: 0x0039B325 File Offset: 0x00399525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingNotify(SettingNotify other) : this()
		{
			this.mobileButtonSettings_ = other.mobileButtonSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BF0 RID: 101360 RVA: 0x0039B34F File Offset: 0x0039954F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingNotify Clone()
		{
			return new SettingNotify(this);
		}

		// Token: 0x1700538A RID: 21386
		// (get) Token: 0x06018BF1 RID: 101361 RVA: 0x0039B357 File Offset: 0x00399557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> MobileButtonSettings
		{
			get
			{
				return this.mobileButtonSettings_;
			}
		}

		// Token: 0x06018BF2 RID: 101362 RVA: 0x0039B35F File Offset: 0x0039955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettingNotify);
		}

		// Token: 0x06018BF3 RID: 101363 RVA: 0x0039B36D File Offset: 0x0039956D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SettingNotify other)
		{
			return other != null && (other == this || (this.mobileButtonSettings_.Equals(other.mobileButtonSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BF4 RID: 101364 RVA: 0x0039B3A0 File Offset: 0x003995A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mobileButtonSettings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018BF5 RID: 101365 RVA: 0x0039B3D4 File Offset: 0x003995D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BF6 RID: 101366 RVA: 0x0039B3E1 File Offset: 0x003995E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BF7 RID: 101367 RVA: 0x0039B3EA File Offset: 0x003995EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mobileButtonSettings_.WriteTo(ref output, SettingNotify._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018BF8 RID: 101368 RVA: 0x0039B414 File Offset: 0x00399614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mobileButtonSettings_.CalculateSize(SettingNotify._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018BF9 RID: 101369 RVA: 0x0039B44D File Offset: 0x0039964D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SettingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mobileButtonSettings_.Add(other.mobileButtonSettings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018BFA RID: 101370 RVA: 0x0039B47B File Offset: 0x0039967B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BFB RID: 101371 RVA: 0x0039B484 File Offset: 0x00399684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mobileButtonSettings_.AddEntriesFrom(ref input, SettingNotify._repeated_mobileButtonSettings_codec);
				}
			}
		}

		// Token: 0x040092CD RID: 37581
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092CE RID: 37582
		public const int MobileButtonSettingsFieldNumber = 2;

		// Token: 0x040092CF RID: 37583
		private static readonly FieldCodec<MobileButtonSetting> _repeated_mobileButtonSettings_codec = FieldCodec.ForMessage<MobileButtonSetting>(18U, MobileButtonSetting.Parser);

		// Token: 0x040092D0 RID: 37584
		private readonly RepeatedField<MobileButtonSetting> mobileButtonSettings_ = new RepeatedField<MobileButtonSetting>();
	}
}
