using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000187 RID: 391
	[NetMessage(EMessageId.BeamReceiveNotify)]
	public sealed class BeamReceiveNotify : IMessage<BeamReceiveNotify>, IMessage, IEquatable<BeamReceiveNotify>, IDeepCloneable<BeamReceiveNotify>, IBufferMessage
	{
		// Token: 0x06002F44 RID: 12100 RVA: 0x0007979D File Offset: 0x0007799D
		[NullableContext(1)]
		public static BeamReceiveNotify Create()
		{
			return new BeamReceiveNotify();
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x000797A4 File Offset: 0x000779A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x000797A7 File Offset: 0x000779A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamReceiveNotify.Descriptor;
			}
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000797AE File Offset: 0x000779AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamReceiveNotify()
		{
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000797B6 File Offset: 0x000779B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamReceiveNotify(BeamReceiveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isSatisfied_ = other.isSatisfied_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000797E7 File Offset: 0x000779E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamReceiveNotify Clone()
		{
			return new BeamReceiveNotify(this);
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x000797EF File Offset: 0x000779EF
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x000797F7 File Offset: 0x000779F7
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x00079800 File Offset: 0x00077A00
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x00079808 File Offset: 0x00077A08
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

		// Token: 0x06002F4E RID: 12110 RVA: 0x00079811 File Offset: 0x00077A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamReceiveNotify);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0007981F File Offset: 0x00077A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamReceiveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsSatisfied == other.IsSatisfied && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00079860 File Offset: 0x00077A60
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

		// Token: 0x06002F51 RID: 12113 RVA: 0x000798B8 File Offset: 0x00077AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000798C5 File Offset: 0x00077AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000798D0 File Offset: 0x00077AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSatisfied)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsSatisfied);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x0007992C File Offset: 0x00077B2C
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

		// Token: 0x06002F55 RID: 12117 RVA: 0x00079978 File Offset: 0x00077B78
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

		// Token: 0x06002F56 RID: 12118 RVA: 0x000799C8 File Offset: 0x00077BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000799D4 File Offset: 0x00077BD4
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
					if (num != 96U)
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

		// Token: 0x040028FA RID: 10490
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028FB RID: 10491
		public const int EntityIdFieldNumber = 12;

		// Token: 0x040028FC RID: 10492
		private long entityId_;

		// Token: 0x040028FD RID: 10493
		public const int IsSatisfiedFieldNumber = 11;

		// Token: 0x040028FE RID: 10494
		private bool isSatisfied_;
	}
}
