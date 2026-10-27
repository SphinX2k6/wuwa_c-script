using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F89 RID: 3977
	[NetMessage(EMessageId.RogueInstExtraInfoRequest)]
	public sealed class RogueInstExtraInfoRequest : IMessage<RogueInstExtraInfoRequest>, IMessage, IEquatable<RogueInstExtraInfoRequest>, IDeepCloneable<RogueInstExtraInfoRequest>, IBufferMessage
	{
		// Token: 0x0601544D RID: 87117 RVA: 0x00315EE6 File Offset: 0x003140E6
		[NullableContext(1)]
		public static RogueInstExtraInfoRequest Create()
		{
			return new RogueInstExtraInfoRequest();
		}

		// Token: 0x170046D7 RID: 18135
		// (get) Token: 0x0601544E RID: 87118 RVA: 0x00315EED File Offset: 0x003140ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046D8 RID: 18136
		// (get) Token: 0x0601544F RID: 87119 RVA: 0x00315EF0 File Offset: 0x003140F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfoRequest.Descriptor;
			}
		}

		// Token: 0x06015450 RID: 87120 RVA: 0x00315EF7 File Offset: 0x003140F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoRequest()
		{
		}

		// Token: 0x06015451 RID: 87121 RVA: 0x00315EFF File Offset: 0x003140FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoRequest(RogueInstExtraInfoRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015452 RID: 87122 RVA: 0x00315F24 File Offset: 0x00314124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoRequest Clone()
		{
			return new RogueInstExtraInfoRequest(this);
		}

		// Token: 0x170046D9 RID: 18137
		// (get) Token: 0x06015453 RID: 87123 RVA: 0x00315F2C File Offset: 0x0031412C
		// (set) Token: 0x06015454 RID: 87124 RVA: 0x00315F34 File Offset: 0x00314134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x06015455 RID: 87125 RVA: 0x00315F3D File Offset: 0x0031413D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfoRequest);
		}

		// Token: 0x06015456 RID: 87126 RVA: 0x00315F4B File Offset: 0x0031414B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfoRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015457 RID: 87127 RVA: 0x00315F7C File Offset: 0x0031417C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015458 RID: 87128 RVA: 0x00315FBB File Offset: 0x003141BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015459 RID: 87129 RVA: 0x00315FC8 File Offset: 0x003141C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601545A RID: 87130 RVA: 0x00315FD1 File Offset: 0x003141D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601545B RID: 87131 RVA: 0x00316004 File Offset: 0x00314204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601545C RID: 87132 RVA: 0x00316042 File Offset: 0x00314242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInstExtraInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601545D RID: 87133 RVA: 0x00316073 File Offset: 0x00314273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601545E RID: 87134 RVA: 0x0031607C File Offset: 0x0031427C
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
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007FFB RID: 32763
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FFC RID: 32764
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x04007FFD RID: 32765
		private int seasonId_;
	}
}
