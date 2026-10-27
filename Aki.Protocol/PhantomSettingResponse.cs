using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D03 RID: 3331
	[NetMessage(EMessageId.PhantomSettingResponse)]
	public sealed class PhantomSettingResponse : IMessage<PhantomSettingResponse>, IMessage, IEquatable<PhantomSettingResponse>, IDeepCloneable<PhantomSettingResponse>, IBufferMessage
	{
		// Token: 0x06012010 RID: 73744 RVA: 0x002A1C3A File Offset: 0x0029FE3A
		[NullableContext(1)]
		public static PhantomSettingResponse Create()
		{
			return new PhantomSettingResponse();
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x06012011 RID: 73745 RVA: 0x002A1C41 File Offset: 0x0029FE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x06012012 RID: 73746 RVA: 0x002A1C44 File Offset: 0x0029FE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingResponse.Descriptor;
			}
		}

		// Token: 0x06012013 RID: 73747 RVA: 0x002A1C4B File Offset: 0x0029FE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingResponse()
		{
		}

		// Token: 0x06012014 RID: 73748 RVA: 0x002A1C69 File Offset: 0x0029FE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingResponse(PhantomSettingResponse other) : this()
		{
			this.autoLockSettings_ = other.autoLockSettings_.Clone();
			this.autoDisuseSettings_ = other.autoDisuseSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012015 RID: 73749 RVA: 0x002A1CA4 File Offset: 0x0029FEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingResponse Clone()
		{
			return new PhantomSettingResponse(this);
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x06012016 RID: 73750 RVA: 0x002A1CAC File Offset: 0x0029FEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnePhantomSetting> AutoLockSettings
		{
			get
			{
				return this.autoLockSettings_;
			}
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x06012017 RID: 73751 RVA: 0x002A1CB4 File Offset: 0x0029FEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnePhantomSetting> AutoDisuseSettings
		{
			get
			{
				return this.autoDisuseSettings_;
			}
		}

		// Token: 0x06012018 RID: 73752 RVA: 0x002A1CBC File Offset: 0x0029FEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingResponse);
		}

		// Token: 0x06012019 RID: 73753 RVA: 0x002A1CCC File Offset: 0x0029FECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingResponse other)
		{
			return other != null && (other == this || (this.autoLockSettings_.Equals(other.autoLockSettings_) && this.autoDisuseSettings_.Equals(other.autoDisuseSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601201A RID: 73754 RVA: 0x002A1D20 File Offset: 0x0029FF20
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

		// Token: 0x0601201B RID: 73755 RVA: 0x002A1D62 File Offset: 0x0029FF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601201C RID: 73756 RVA: 0x002A1D6F File Offset: 0x0029FF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601201D RID: 73757 RVA: 0x002A1D78 File Offset: 0x0029FF78
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

		// Token: 0x0601201E RID: 73758 RVA: 0x002A1DB0 File Offset: 0x0029FFB0
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

		// Token: 0x0601201F RID: 73759 RVA: 0x002A1DFC File Offset: 0x0029FFFC
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

		// Token: 0x06012020 RID: 73760 RVA: 0x002A1E3B File Offset: 0x002A003B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012021 RID: 73761 RVA: 0x002A1E44 File Offset: 0x002A0044
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
				if (num != 90U)
				{
					if (num != 122U)
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

		// Token: 0x040070C7 RID: 28871
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070C8 RID: 28872
		public const int AutoLockSettingsFieldNumber = 15;

		// Token: 0x040070C9 RID: 28873
		private static readonly FieldCodec<OnePhantomSetting> _repeated_autoLockSettings_codec = FieldCodec.ForMessage<OnePhantomSetting>(122U, OnePhantomSetting.Parser);

		// Token: 0x040070CA RID: 28874
		private readonly RepeatedField<OnePhantomSetting> autoLockSettings_ = new RepeatedField<OnePhantomSetting>();

		// Token: 0x040070CB RID: 28875
		public const int AutoDisuseSettingsFieldNumber = 11;

		// Token: 0x040070CC RID: 28876
		private static readonly FieldCodec<OnePhantomSetting> _repeated_autoDisuseSettings_codec = FieldCodec.ForMessage<OnePhantomSetting>(90U, OnePhantomSetting.Parser);

		// Token: 0x040070CD RID: 28877
		private readonly RepeatedField<OnePhantomSetting> autoDisuseSettings_ = new RepeatedField<OnePhantomSetting>();
	}
}
