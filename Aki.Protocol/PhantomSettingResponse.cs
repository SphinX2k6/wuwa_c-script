using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF3 RID: 3315
	[NetMessage(EMessageId.PhantomSettingResponse)]
	public sealed class PhantomSettingResponse : IMessage<PhantomSettingResponse>, IMessage, IEquatable<PhantomSettingResponse>, IDeepCloneable<PhantomSettingResponse>, IBufferMessage
	{
		// Token: 0x06011F14 RID: 73492 RVA: 0x002A0022 File Offset: 0x0029E222
		[NullableContext(1)]
		public static PhantomSettingResponse Create()
		{
			return new PhantomSettingResponse();
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x06011F15 RID: 73493 RVA: 0x002A0029 File Offset: 0x0029E229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x06011F16 RID: 73494 RVA: 0x002A002C File Offset: 0x0029E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingResponse.Descriptor;
			}
		}

		// Token: 0x06011F17 RID: 73495 RVA: 0x002A0033 File Offset: 0x0029E233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingResponse()
		{
		}

		// Token: 0x06011F18 RID: 73496 RVA: 0x002A0051 File Offset: 0x0029E251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingResponse(PhantomSettingResponse other) : this()
		{
			this.autoLockSettings_ = other.autoLockSettings_.Clone();
			this.autoDisuseSettings_ = other.autoDisuseSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F19 RID: 73497 RVA: 0x002A008C File Offset: 0x0029E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingResponse Clone()
		{
			return new PhantomSettingResponse(this);
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x06011F1A RID: 73498 RVA: 0x002A0094 File Offset: 0x0029E294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnePhantomSetting> AutoLockSettings
		{
			get
			{
				return this.autoLockSettings_;
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x06011F1B RID: 73499 RVA: 0x002A009C File Offset: 0x0029E29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnePhantomSetting> AutoDisuseSettings
		{
			get
			{
				return this.autoDisuseSettings_;
			}
		}

		// Token: 0x06011F1C RID: 73500 RVA: 0x002A00A4 File Offset: 0x0029E2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingResponse);
		}

		// Token: 0x06011F1D RID: 73501 RVA: 0x002A00B4 File Offset: 0x0029E2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingResponse other)
		{
			return other != null && (other == this || (this.autoLockSettings_.Equals(other.autoLockSettings_) && this.autoDisuseSettings_.Equals(other.autoDisuseSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F1E RID: 73502 RVA: 0x002A0108 File Offset: 0x0029E308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.autoLockSettings_.GetHashCode();
			num ^= this.autoDisuseSettings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F1F RID: 73503 RVA: 0x002A014A File Offset: 0x0029E34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F20 RID: 73504 RVA: 0x002A0157 File Offset: 0x0029E357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F21 RID: 73505 RVA: 0x002A0160 File Offset: 0x0029E360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.autoDisuseSettings_.WriteTo(ref output, PhantomSettingResponse._repeated_autoDisuseSettings_codec);
			this.autoLockSettings_.WriteTo(ref output, PhantomSettingResponse._repeated_autoLockSettings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F22 RID: 73506 RVA: 0x002A0198 File Offset: 0x0029E398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.autoLockSettings_.CalculateSize(PhantomSettingResponse._repeated_autoLockSettings_codec);
			num += this.autoDisuseSettings_.CalculateSize(PhantomSettingResponse._repeated_autoDisuseSettings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F23 RID: 73507 RVA: 0x002A01E4 File Offset: 0x0029E3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.autoLockSettings_.Add(other.autoLockSettings_);
			this.autoDisuseSettings_.Add(other.autoDisuseSettings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F24 RID: 73508 RVA: 0x002A0223 File Offset: 0x0029E423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F25 RID: 73509 RVA: 0x002A022C File Offset: 0x0029E42C
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
				if (num != 10U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.autoLockSettings_.AddEntriesFrom(ref input, PhantomSettingResponse._repeated_autoLockSettings_codec);
					}
				}
				else
				{
					this.autoDisuseSettings_.AddEntriesFrom(ref input, PhantomSettingResponse._repeated_autoDisuseSettings_codec);
				}
			}
		}

		// Token: 0x040070DF RID: 28895
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070E0 RID: 28896
		public const int AutoLockSettingsFieldNumber = 13;

		// Token: 0x040070E1 RID: 28897
		private static readonly FieldCodec<OnePhantomSetting> _repeated_autoLockSettings_codec = FieldCodec.ForMessage<OnePhantomSetting>(106U, OnePhantomSetting.Parser);

		// Token: 0x040070E2 RID: 28898
		private readonly RepeatedField<OnePhantomSetting> autoLockSettings_ = new RepeatedField<OnePhantomSetting>();

		// Token: 0x040070E3 RID: 28899
		public const int AutoDisuseSettingsFieldNumber = 1;

		// Token: 0x040070E4 RID: 28900
		private static readonly FieldCodec<OnePhantomSetting> _repeated_autoDisuseSettings_codec = FieldCodec.ForMessage<OnePhantomSetting>(10U, OnePhantomSetting.Parser);

		// Token: 0x040070E5 RID: 28901
		private readonly RepeatedField<OnePhantomSetting> autoDisuseSettings_ = new RepeatedField<OnePhantomSetting>();
	}
}
