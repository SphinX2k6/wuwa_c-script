using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A09 RID: 2569
	[NetMessage(EMessageId.MoraleTreasureBoxTraceRequest)]
	public sealed class MoraleTreasureBoxTraceRequest : IMessage<MoraleTreasureBoxTraceRequest>, IMessage, IEquatable<MoraleTreasureBoxTraceRequest>, IDeepCloneable<MoraleTreasureBoxTraceRequest>, IBufferMessage
	{
		// Token: 0x0600E112 RID: 57618 RVA: 0x0020FD95 File Offset: 0x0020DF95
		[NullableContext(1)]
		public static MoraleTreasureBoxTraceRequest Create()
		{
			return new MoraleTreasureBoxTraceRequest();
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0600E113 RID: 57619 RVA: 0x0020FD9C File Offset: 0x0020DF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x0600E114 RID: 57620 RVA: 0x0020FD9F File Offset: 0x0020DF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleTreasureBoxTraceRequest.Descriptor;
			}
		}

		// Token: 0x0600E115 RID: 57621 RVA: 0x0020FDA6 File Offset: 0x0020DFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceRequest()
		{
		}

		// Token: 0x0600E116 RID: 57622 RVA: 0x0020FDAE File Offset: 0x0020DFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceRequest(MoraleTreasureBoxTraceRequest other) : this()
		{
			this.areaPos_ = other.areaPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E117 RID: 57623 RVA: 0x0020FDD3 File Offset: 0x0020DFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceRequest Clone()
		{
			return new MoraleTreasureBoxTraceRequest(this);
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0600E118 RID: 57624 RVA: 0x0020FDDB File Offset: 0x0020DFDB
		// (set) Token: 0x0600E119 RID: 57625 RVA: 0x0020FDE3 File Offset: 0x0020DFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaPos
		{
			get
			{
				return this.areaPos_;
			}
			set
			{
				this.areaPos_ = value;
			}
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x0020FDEC File Offset: 0x0020DFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleTreasureBoxTraceRequest);
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x0020FDFA File Offset: 0x0020DFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleTreasureBoxTraceRequest other)
		{
			return other != null && (other == this || (this.AreaPos == other.AreaPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x0020FE28 File Offset: 0x0020E028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaPos != 0)
			{
				num ^= this.AreaPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E11D RID: 57629 RVA: 0x0020FE67 File Offset: 0x0020E067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E11E RID: 57630 RVA: 0x0020FE74 File Offset: 0x0020E074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E11F RID: 57631 RVA: 0x0020FE7D File Offset: 0x0020E07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaPos != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E120 RID: 57632 RVA: 0x0020FEB0 File Offset: 0x0020E0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E121 RID: 57633 RVA: 0x0020FEEE File Offset: 0x0020E0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleTreasureBoxTraceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaPos != 0)
			{
				this.AreaPos = other.AreaPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E122 RID: 57634 RVA: 0x0020FF1F File Offset: 0x0020E11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E123 RID: 57635 RVA: 0x0020FF28 File Offset: 0x0020E128
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaPos = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005CEB RID: 23787
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CEC RID: 23788
		public const int AreaPosFieldNumber = 11;

		// Token: 0x04005CED RID: 23789
		private int areaPos_;
	}
}
