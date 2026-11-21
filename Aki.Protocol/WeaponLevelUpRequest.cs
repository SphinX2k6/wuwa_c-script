using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001569 RID: 5481
	[NetMessage(EMessageId.WeaponLevelUpRequest)]
	public sealed class WeaponLevelUpRequest : IMessage<WeaponLevelUpRequest>, IMessage, IEquatable<WeaponLevelUpRequest>, IDeepCloneable<WeaponLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601D070 RID: 118896 RVA: 0x004345DD File Offset: 0x004327DD
		[NullableContext(1)]
		public static WeaponLevelUpRequest Create()
		{
			return new WeaponLevelUpRequest();
		}

		// Token: 0x17006238 RID: 25144
		// (get) Token: 0x0601D071 RID: 118897 RVA: 0x004345E4 File Offset: 0x004327E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006239 RID: 25145
		// (get) Token: 0x0601D072 RID: 118898 RVA: 0x004345E7 File Offset: 0x004327E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601D073 RID: 118899 RVA: 0x004345EE File Offset: 0x004327EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpRequest()
		{
		}

		// Token: 0x0601D074 RID: 118900 RVA: 0x00434601 File Offset: 0x00432801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpRequest(WeaponLevelUpRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.consumeList_ = other.consumeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D075 RID: 118901 RVA: 0x00434637 File Offset: 0x00432837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpRequest Clone()
		{
			return new WeaponLevelUpRequest(this);
		}

		// Token: 0x1700623A RID: 25146
		// (get) Token: 0x0601D076 RID: 118902 RVA: 0x0043463F File Offset: 0x0043283F
		// (set) Token: 0x0601D077 RID: 118903 RVA: 0x00434647 File Offset: 0x00432847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700623B RID: 25147
		// (get) Token: 0x0601D078 RID: 118904 RVA: 0x00434650 File Offset: 0x00432850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponConsumeItem> ConsumeList
		{
			get
			{
				return this.consumeList_;
			}
		}

		// Token: 0x0601D079 RID: 118905 RVA: 0x00434658 File Offset: 0x00432858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponLevelUpRequest);
		}

		// Token: 0x0601D07A RID: 118906 RVA: 0x00434668 File Offset: 0x00432868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponLevelUpRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.consumeList_.Equals(other.consumeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D07B RID: 118907 RVA: 0x004346B8 File Offset: 0x004328B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.consumeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D07C RID: 118908 RVA: 0x00434705 File Offset: 0x00432905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D07D RID: 118909 RVA: 0x00434712 File Offset: 0x00432912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D07E RID: 118910 RVA: 0x0043471C File Offset: 0x0043291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.IncId);
			}
			this.consumeList_.WriteTo(ref output, WeaponLevelUpRequest._repeated_consumeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D07F RID: 118911 RVA: 0x0043476C File Offset: 0x0043296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.consumeList_.CalculateSize(WeaponLevelUpRequest._repeated_consumeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D080 RID: 118912 RVA: 0x004347C0 File Offset: 0x004329C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.consumeList_.Add(other.consumeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D081 RID: 118913 RVA: 0x0043480D File Offset: 0x00432A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D082 RID: 118914 RVA: 0x00434818 File Offset: 0x00432A18
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
				if (num != 64U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.consumeList_.AddEntriesFrom(ref input, WeaponLevelUpRequest._repeated_consumeList_codec);
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A6C6 RID: 42694
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6C7 RID: 42695
		public const int IncIdFieldNumber = 8;

		// Token: 0x0400A6C8 RID: 42696
		private int incId_;

		// Token: 0x0400A6C9 RID: 42697
		public const int ConsumeListFieldNumber = 14;

		// Token: 0x0400A6CA RID: 42698
		private static readonly FieldCodec<WeaponConsumeItem> _repeated_consumeList_codec = FieldCodec.ForMessage<WeaponConsumeItem>(114U, WeaponConsumeItem.Parser);

		// Token: 0x0400A6CB RID: 42699
		private readonly RepeatedField<WeaponConsumeItem> consumeList_ = new RepeatedField<WeaponConsumeItem>();
	}
}
