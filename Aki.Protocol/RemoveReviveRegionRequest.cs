using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F08 RID: 3848
	[NetMessage(EMessageId.RemoveReviveRegionRequest)]
	public sealed class RemoveReviveRegionRequest : IMessage<RemoveReviveRegionRequest>, IMessage, IEquatable<RemoveReviveRegionRequest>, IDeepCloneable<RemoveReviveRegionRequest>, IBufferMessage
	{
		// Token: 0x060149BE RID: 84414 RVA: 0x002FE2FB File Offset: 0x002FC4FB
		[NullableContext(1)]
		public static RemoveReviveRegionRequest Create()
		{
			return new RemoveReviveRegionRequest();
		}

		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x060149BF RID: 84415 RVA: 0x002FE302 File Offset: 0x002FC502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x060149C0 RID: 84416 RVA: 0x002FE305 File Offset: 0x002FC505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveReviveRegionRequest.Descriptor;
			}
		}

		// Token: 0x060149C1 RID: 84417 RVA: 0x002FE30C File Offset: 0x002FC50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionRequest()
		{
		}

		// Token: 0x060149C2 RID: 84418 RVA: 0x002FE314 File Offset: 0x002FC514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionRequest(RemoveReviveRegionRequest other) : this()
		{
			this.reviveId_ = other.reviveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149C3 RID: 84419 RVA: 0x002FE339 File Offset: 0x002FC539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionRequest Clone()
		{
			return new RemoveReviveRegionRequest(this);
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x060149C4 RID: 84420 RVA: 0x002FE341 File Offset: 0x002FC541
		// (set) Token: 0x060149C5 RID: 84421 RVA: 0x002FE349 File Offset: 0x002FC549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveId
		{
			get
			{
				return this.reviveId_;
			}
			set
			{
				this.reviveId_ = value;
			}
		}

		// Token: 0x060149C6 RID: 84422 RVA: 0x002FE352 File Offset: 0x002FC552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveReviveRegionRequest);
		}

		// Token: 0x060149C7 RID: 84423 RVA: 0x002FE360 File Offset: 0x002FC560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveReviveRegionRequest other)
		{
			return other != null && (other == this || (this.ReviveId == other.ReviveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149C8 RID: 84424 RVA: 0x002FE390 File Offset: 0x002FC590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReviveId != 0)
			{
				num ^= this.ReviveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060149C9 RID: 84425 RVA: 0x002FE3CF File Offset: 0x002FC5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149CA RID: 84426 RVA: 0x002FE3DC File Offset: 0x002FC5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149CB RID: 84427 RVA: 0x002FE3E5 File Offset: 0x002FC5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ReviveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060149CC RID: 84428 RVA: 0x002FE418 File Offset: 0x002FC618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReviveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060149CD RID: 84429 RVA: 0x002FE456 File Offset: 0x002FC656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveReviveRegionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReviveId != 0)
			{
				this.ReviveId = other.ReviveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060149CE RID: 84430 RVA: 0x002FE487 File Offset: 0x002FC687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149CF RID: 84431 RVA: 0x002FE490 File Offset: 0x002FC690
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ReviveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CC4 RID: 31940
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CC5 RID: 31941
		public const int ReviveIdFieldNumber = 7;

		// Token: 0x04007CC6 RID: 31942
		private int reviveId_;
	}
}
