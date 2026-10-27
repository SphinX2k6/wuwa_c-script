using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000689 RID: 1673
	[NetMessage(EMessageId.GachaAccumulateInfoRequest)]
	public sealed class GachaAccumulateInfoRequest : IMessage<GachaAccumulateInfoRequest>, IMessage, IEquatable<GachaAccumulateInfoRequest>, IDeepCloneable<GachaAccumulateInfoRequest>, IBufferMessage
	{
		// Token: 0x06009921 RID: 39201 RVA: 0x00170D3C File Offset: 0x0016EF3C
		[NullableContext(1)]
		public static GachaAccumulateInfoRequest Create()
		{
			return new GachaAccumulateInfoRequest();
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06009922 RID: 39202 RVA: 0x00170D43 File Offset: 0x0016EF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06009923 RID: 39203 RVA: 0x00170D46 File Offset: 0x0016EF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfoRequest.Descriptor;
			}
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x00170D4D File Offset: 0x0016EF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoRequest()
		{
		}

		// Token: 0x06009925 RID: 39205 RVA: 0x00170D55 File Offset: 0x0016EF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoRequest(GachaAccumulateInfoRequest other) : this()
		{
			this.gachaAccumulateId_ = other.gachaAccumulateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009926 RID: 39206 RVA: 0x00170D7A File Offset: 0x0016EF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoRequest Clone()
		{
			return new GachaAccumulateInfoRequest(this);
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x00170D82 File Offset: 0x0016EF82
		// (set) Token: 0x06009928 RID: 39208 RVA: 0x00170D8A File Offset: 0x0016EF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaAccumulateId
		{
			get
			{
				return this.gachaAccumulateId_;
			}
			set
			{
				this.gachaAccumulateId_ = value;
			}
		}

		// Token: 0x06009929 RID: 39209 RVA: 0x00170D93 File Offset: 0x0016EF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfoRequest);
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x00170DA1 File Offset: 0x0016EFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfoRequest other)
		{
			return other != null && (other == this || (this.GachaAccumulateId == other.GachaAccumulateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x00170DD0 File Offset: 0x0016EFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaAccumulateId != 0)
			{
				num ^= this.GachaAccumulateId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x00170E0F File Offset: 0x0016F00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x00170E1C File Offset: 0x0016F01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x00170E25 File Offset: 0x0016F025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaAccumulateId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GachaAccumulateId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600992F RID: 39215 RVA: 0x00170E58 File Offset: 0x0016F058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaAccumulateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaAccumulateId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009930 RID: 39216 RVA: 0x00170E96 File Offset: 0x0016F096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaAccumulateId != 0)
			{
				this.GachaAccumulateId = other.GachaAccumulateId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x00170EC7 File Offset: 0x0016F0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009932 RID: 39218 RVA: 0x00170ED0 File Offset: 0x0016F0D0
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GachaAccumulateId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004877 RID: 18551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004878 RID: 18552
		public const int GachaAccumulateIdFieldNumber = 1;

		// Token: 0x04004879 RID: 18553
		private int gachaAccumulateId_;
	}
}
