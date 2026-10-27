using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000184 RID: 388
	[NetMessage(EMessageId.BeamReceiveNotify)]
	public sealed class BeamReceiveNotify : IMessage<BeamReceiveNotify>, IMessage, IEquatable<BeamReceiveNotify>, IDeepCloneable<BeamReceiveNotify>, IBufferMessage
	{
		// Token: 0x06002ECD RID: 11981 RVA: 0x0007836C File Offset: 0x0007656C
		[NullableContext(1)]
		public static BeamReceiveNotify Create()
		{
			return new BeamReceiveNotify();
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x00078373 File Offset: 0x00076573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x00078376 File Offset: 0x00076576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamReceiveNotify.Descriptor;
			}
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x0007837D File Offset: 0x0007657D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamReceiveNotify()
		{
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00078385 File Offset: 0x00076585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamReceiveNotify(BeamReceiveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isSatisfied_ = other.isSatisfied_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x000783B6 File Offset: 0x000765B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamReceiveNotify Clone()
		{
			return new BeamReceiveNotify(this);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x000783BE File Offset: 0x000765BE
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x000783C6 File Offset: 0x000765C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x000783CF File Offset: 0x000765CF
		// (set) Token: 0x06002ED6 RID: 11990 RVA: 0x000783D7 File Offset: 0x000765D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSatisfied
		{
			get
			{
				return this.isSatisfied_;
			}
			set
			{
				this.isSatisfied_ = value;
			}
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x000783E0 File Offset: 0x000765E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamReceiveNotify);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x000783EE File Offset: 0x000765EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamReceiveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsSatisfied == other.IsSatisfied && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x0007842C File Offset: 0x0007662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsSatisfied)
			{
				num ^= this.IsSatisfied.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x00078484 File Offset: 0x00076684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00078491 File Offset: 0x00076691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x0007849C File Offset: 0x0007669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSatisfied)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSatisfied);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000784F8 File Offset: 0x000766F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsSatisfied)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00078544 File Offset: 0x00076744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeamReceiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsSatisfied)
			{
				this.IsSatisfied = other.IsSatisfied;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00078594 File Offset: 0x00076794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000785A0 File Offset: 0x000767A0
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
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsSatisfied = input.ReadBool();
				}
			}
		}

		// Token: 0x04002886 RID: 10374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002887 RID: 10375
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04002888 RID: 10376
		private long entityId_;

		// Token: 0x04002889 RID: 10377
		public const int IsSatisfiedFieldNumber = 2;

		// Token: 0x0400288A RID: 10378
		private bool isSatisfied_;
	}
}
