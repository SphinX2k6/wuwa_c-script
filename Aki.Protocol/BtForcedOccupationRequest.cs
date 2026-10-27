using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E7 RID: 487
	[NetMessage(EMessageId.BtForcedOccupationRequest)]
	public sealed class BtForcedOccupationRequest : IMessage<BtForcedOccupationRequest>, IMessage, IEquatable<BtForcedOccupationRequest>, IDeepCloneable<BtForcedOccupationRequest>, IBufferMessage
	{
		// Token: 0x060036A5 RID: 13989 RVA: 0x00088FBD File Offset: 0x000871BD
		[NullableContext(1)]
		public static BtForcedOccupationRequest Create()
		{
			return new BtForcedOccupationRequest();
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x00088FC4 File Offset: 0x000871C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x00088FC7 File Offset: 0x000871C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtForcedOccupationRequest.Descriptor;
			}
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00088FCE File Offset: 0x000871CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationRequest()
		{
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x00088FD6 File Offset: 0x000871D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationRequest(BtForcedOccupationRequest other) : this()
		{
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x00088FFB File Offset: 0x000871FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationRequest Clone()
		{
			return new BtForcedOccupationRequest(this);
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x00089003 File Offset: 0x00087203
		// (set) Token: 0x060036AC RID: 13996 RVA: 0x0008900B File Offset: 0x0008720B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00089014 File Offset: 0x00087214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtForcedOccupationRequest);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00089022 File Offset: 0x00087222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtForcedOccupationRequest other)
		{
			return other != null && (other == this || (this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00089050 File Offset: 0x00087250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0008908F File Offset: 0x0008728F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0008909C File Offset: 0x0008729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x000890A5 File Offset: 0x000872A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x000890D8 File Offset: 0x000872D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x00089116 File Offset: 0x00087316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtForcedOccupationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00089147 File Offset: 0x00087347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00089150 File Offset: 0x00087350
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
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002AAD RID: 10925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AAE RID: 10926
		public const int TreeIncIdFieldNumber = 1;

		// Token: 0x04002AAF RID: 10927
		private long treeIncId_;
	}
}
