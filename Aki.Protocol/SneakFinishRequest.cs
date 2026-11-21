using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001296 RID: 4758
	[NetMessage(EMessageId.SneakFinishRequest)]
	public sealed class SneakFinishRequest : IMessage<SneakFinishRequest>, IMessage, IEquatable<SneakFinishRequest>, IDeepCloneable<SneakFinishRequest>, IBufferMessage
	{
		// Token: 0x06019655 RID: 104021 RVA: 0x003B42AB File Offset: 0x003B24AB
		[NullableContext(1)]
		public static SneakFinishRequest Create()
		{
			return new SneakFinishRequest();
		}

		// Token: 0x170055E7 RID: 21991
		// (get) Token: 0x06019656 RID: 104022 RVA: 0x003B42B2 File Offset: 0x003B24B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055E8 RID: 21992
		// (get) Token: 0x06019657 RID: 104023 RVA: 0x003B42B5 File Offset: 0x003B24B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakFinishRequest.Descriptor;
			}
		}

		// Token: 0x06019658 RID: 104024 RVA: 0x003B42BC File Offset: 0x003B24BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishRequest()
		{
		}

		// Token: 0x06019659 RID: 104025 RVA: 0x003B42C4 File Offset: 0x003B24C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishRequest(SneakFinishRequest other) : this()
		{
			this.sneakId_ = other.sneakId_;
			this.finishType_ = other.finishType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601965A RID: 104026 RVA: 0x003B42F5 File Offset: 0x003B24F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishRequest Clone()
		{
			return new SneakFinishRequest(this);
		}

		// Token: 0x170055E9 RID: 21993
		// (get) Token: 0x0601965B RID: 104027 RVA: 0x003B42FD File Offset: 0x003B24FD
		// (set) Token: 0x0601965C RID: 104028 RVA: 0x003B4305 File Offset: 0x003B2505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SneakId
		{
			get
			{
				return this.sneakId_;
			}
			set
			{
				this.sneakId_ = value;
			}
		}

		// Token: 0x170055EA RID: 21994
		// (get) Token: 0x0601965D RID: 104029 RVA: 0x003B430E File Offset: 0x003B250E
		// (set) Token: 0x0601965E RID: 104030 RVA: 0x003B4316 File Offset: 0x003B2516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishType FinishType
		{
			get
			{
				return this.finishType_;
			}
			set
			{
				this.finishType_ = value;
			}
		}

		// Token: 0x0601965F RID: 104031 RVA: 0x003B431F File Offset: 0x003B251F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakFinishRequest);
		}

		// Token: 0x06019660 RID: 104032 RVA: 0x003B432D File Offset: 0x003B252D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakFinishRequest other)
		{
			return other != null && (other == this || (this.SneakId == other.SneakId && this.FinishType == other.FinishType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019661 RID: 104033 RVA: 0x003B436C File Offset: 0x003B256C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SneakId != 0)
			{
				num ^= this.SneakId.GetHashCode();
			}
			if (this.FinishType != SneakFinishType.SneakSuccess)
			{
				num ^= this.FinishType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019662 RID: 104034 RVA: 0x003B43CA File Offset: 0x003B25CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019663 RID: 104035 RVA: 0x003B43D7 File Offset: 0x003B25D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019664 RID: 104036 RVA: 0x003B43E0 File Offset: 0x003B25E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SneakId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SneakId);
			}
			if (this.FinishType != SneakFinishType.SneakSuccess)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.FinishType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019665 RID: 104037 RVA: 0x003B443C File Offset: 0x003B263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SneakId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SneakId);
			}
			if (this.FinishType != SneakFinishType.SneakSuccess)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FinishType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019666 RID: 104038 RVA: 0x003B4494 File Offset: 0x003B2694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SneakId != 0)
			{
				this.SneakId = other.SneakId;
			}
			if (other.FinishType != SneakFinishType.SneakSuccess)
			{
				this.FinishType = other.FinishType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019667 RID: 104039 RVA: 0x003B44E4 File Offset: 0x003B26E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019668 RID: 104040 RVA: 0x003B44F0 File Offset: 0x003B26F0
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
				if (num != 16U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FinishType = (SneakFinishType)input.ReadEnum();
					}
				}
				else
				{
					this.SneakId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400962B RID: 38443
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400962C RID: 38444
		public const int SneakIdFieldNumber = 2;

		// Token: 0x0400962D RID: 38445
		private int sneakId_;

		// Token: 0x0400962E RID: 38446
		public const int FinishTypeFieldNumber = 14;

		// Token: 0x0400962F RID: 38447
		private SneakFinishType finishType_;
	}
}
