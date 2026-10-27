using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FF RID: 1023
	[NetMessage(EMessageId.DragonPoolConfRequest)]
	public sealed class DragonPoolConfRequest : IMessage<DragonPoolConfRequest>, IMessage, IEquatable<DragonPoolConfRequest>, IDeepCloneable<DragonPoolConfRequest>, IBufferMessage
	{
		// Token: 0x060062CF RID: 25295 RVA: 0x000EDD73 File Offset: 0x000EBF73
		[NullableContext(1)]
		public static DragonPoolConfRequest Create()
		{
			return new DragonPoolConfRequest();
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x000EDD7A File Offset: 0x000EBF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060062D1 RID: 25297 RVA: 0x000EDD7D File Offset: 0x000EBF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolConfRequest.Descriptor;
			}
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x000EDD84 File Offset: 0x000EBF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfRequest()
		{
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x000EDD8C File Offset: 0x000EBF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfRequest(DragonPoolConfRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x000EDDB1 File Offset: 0x000EBFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfRequest Clone()
		{
			return new DragonPoolConfRequest(this);
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060062D5 RID: 25301 RVA: 0x000EDDB9 File Offset: 0x000EBFB9
		// (set) Token: 0x060062D6 RID: 25302 RVA: 0x000EDDC1 File Offset: 0x000EBFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x000EDDCA File Offset: 0x000EBFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolConfRequest);
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x000EDDD8 File Offset: 0x000EBFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolConfRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x000EDE08 File Offset: 0x000EC008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x000EDE47 File Offset: 0x000EC047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x000EDE54 File Offset: 0x000EC054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x000EDE5D File Offset: 0x000EC05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x000EDE90 File Offset: 0x000EC090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x000EDECE File Offset: 0x000EC0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DragonPoolConfRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x000EDEFF File Offset: 0x000EC0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x000EDF08 File Offset: 0x000EC108
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037F6 RID: 14326
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037F7 RID: 14327
		public const int DragonPoolIdFieldNumber = 3;

		// Token: 0x040037F8 RID: 14328
		private int dragonPoolId_;
	}
}
