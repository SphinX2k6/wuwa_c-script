using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADE RID: 2782
	[NetMessage(EMessageId.MulGetAdventureRewardRequest)]
	public sealed class MulGetAdventureRewardRequest : IMessage<MulGetAdventureRewardRequest>, IMessage, IEquatable<MulGetAdventureRewardRequest>, IDeepCloneable<MulGetAdventureRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F20B RID: 61963 RVA: 0x00235898 File Offset: 0x00233A98
		[NullableContext(1)]
		public static MulGetAdventureRewardRequest Create()
		{
			return new MulGetAdventureRewardRequest();
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600F20C RID: 61964 RVA: 0x0023589F File Offset: 0x00233A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600F20D RID: 61965 RVA: 0x002358A2 File Offset: 0x00233AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulGetAdventureRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F20E RID: 61966 RVA: 0x002358A9 File Offset: 0x00233AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardRequest()
		{
		}

		// Token: 0x0600F20F RID: 61967 RVA: 0x002358BC File Offset: 0x00233ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardRequest(MulGetAdventureRewardRequest other) : this()
		{
			this.id_ = other.id_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F210 RID: 61968 RVA: 0x002358E6 File Offset: 0x00233AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardRequest Clone()
		{
			return new MulGetAdventureRewardRequest(this);
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600F211 RID: 61969 RVA: 0x002358EE File Offset: 0x00233AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			get
			{
				return this.id_;
			}
		}

		// Token: 0x0600F212 RID: 61970 RVA: 0x002358F6 File Offset: 0x00233AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulGetAdventureRewardRequest);
		}

		// Token: 0x0600F213 RID: 61971 RVA: 0x00235904 File Offset: 0x00233B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulGetAdventureRewardRequest other)
		{
			return other != null && (other == this || (this.id_.Equals(other.id_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F214 RID: 61972 RVA: 0x00235938 File Offset: 0x00233B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.id_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F215 RID: 61973 RVA: 0x0023596C File Offset: 0x00233B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F216 RID: 61974 RVA: 0x00235979 File Offset: 0x00233B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F217 RID: 61975 RVA: 0x00235982 File Offset: 0x00233B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.id_.WriteTo(ref output, MulGetAdventureRewardRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F218 RID: 61976 RVA: 0x002359AC File Offset: 0x00233BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.id_.CalculateSize(MulGetAdventureRewardRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F219 RID: 61977 RVA: 0x002359E5 File Offset: 0x00233BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulGetAdventureRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.id_.Add(other.id_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F21A RID: 61978 RVA: 0x00235A13 File Offset: 0x00233C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F21B RID: 61979 RVA: 0x00235A1C File Offset: 0x00233C1C
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.id_.AddEntriesFrom(ref input, MulGetAdventureRewardRequest._repeated_id_codec);
				}
			}
		}

		// Token: 0x040061B2 RID: 25010
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061B3 RID: 25011
		public const int IdFieldNumber = 7;

		// Token: 0x040061B4 RID: 25012
		private static readonly FieldCodec<int> _repeated_id_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040061B5 RID: 25013
		private readonly RepeatedField<int> id_ = new RepeatedField<int>();
	}
}
