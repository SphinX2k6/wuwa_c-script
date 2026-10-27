using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF5 RID: 3829
	[NetMessage(EMessageId.RemoveCombineRelationNotify)]
	public sealed class RemoveCombineRelationNotify : IMessage<RemoveCombineRelationNotify>, IMessage, IEquatable<RemoveCombineRelationNotify>, IDeepCloneable<RemoveCombineRelationNotify>, IBufferMessage
	{
		// Token: 0x06014846 RID: 84038 RVA: 0x002FB2C5 File Offset: 0x002F94C5
		[NullableContext(1)]
		public static RemoveCombineRelationNotify Create()
		{
			return new RemoveCombineRelationNotify();
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x06014847 RID: 84039 RVA: 0x002FB2CC File Offset: 0x002F94CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x06014848 RID: 84040 RVA: 0x002FB2CF File Offset: 0x002F94CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveCombineRelationNotify.Descriptor;
			}
		}

		// Token: 0x06014849 RID: 84041 RVA: 0x002FB2D6 File Offset: 0x002F94D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveCombineRelationNotify()
		{
		}

		// Token: 0x0601484A RID: 84042 RVA: 0x002FB2DE File Offset: 0x002F94DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveCombineRelationNotify(RemoveCombineRelationNotify other) : this()
		{
			this.combinerEntity_ = other.combinerEntity_;
			this.targetEntity_ = other.targetEntity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601484B RID: 84043 RVA: 0x002FB30F File Offset: 0x002F950F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveCombineRelationNotify Clone()
		{
			return new RemoveCombineRelationNotify(this);
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x0601484C RID: 84044 RVA: 0x002FB317 File Offset: 0x002F9517
		// (set) Token: 0x0601484D RID: 84045 RVA: 0x002FB31F File Offset: 0x002F951F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CombinerEntity
		{
			get
			{
				return this.combinerEntity_;
			}
			set
			{
				this.combinerEntity_ = value;
			}
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x0601484E RID: 84046 RVA: 0x002FB328 File Offset: 0x002F9528
		// (set) Token: 0x0601484F RID: 84047 RVA: 0x002FB330 File Offset: 0x002F9530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntity
		{
			get
			{
				return this.targetEntity_;
			}
			set
			{
				this.targetEntity_ = value;
			}
		}

		// Token: 0x06014850 RID: 84048 RVA: 0x002FB339 File Offset: 0x002F9539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveCombineRelationNotify);
		}

		// Token: 0x06014851 RID: 84049 RVA: 0x002FB347 File Offset: 0x002F9547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveCombineRelationNotify other)
		{
			return other != null && (other == this || (this.CombinerEntity == other.CombinerEntity && this.TargetEntity == other.TargetEntity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014852 RID: 84050 RVA: 0x002FB388 File Offset: 0x002F9588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CombinerEntity != 0L)
			{
				num ^= this.CombinerEntity.GetHashCode();
			}
			if (this.TargetEntity != 0L)
			{
				num ^= this.TargetEntity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014853 RID: 84051 RVA: 0x002FB3E0 File Offset: 0x002F95E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014854 RID: 84052 RVA: 0x002FB3ED File Offset: 0x002F95ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014855 RID: 84053 RVA: 0x002FB3F8 File Offset: 0x002F95F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntity != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TargetEntity);
			}
			if (this.CombinerEntity != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CombinerEntity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014856 RID: 84054 RVA: 0x002FB454 File Offset: 0x002F9654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CombinerEntity != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CombinerEntity);
			}
			if (this.TargetEntity != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014857 RID: 84055 RVA: 0x002FB4AC File Offset: 0x002F96AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveCombineRelationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CombinerEntity != 0L)
			{
				this.CombinerEntity = other.CombinerEntity;
			}
			if (other.TargetEntity != 0L)
			{
				this.TargetEntity = other.TargetEntity;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014858 RID: 84056 RVA: 0x002FB4FC File Offset: 0x002F96FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014859 RID: 84057 RVA: 0x002FB508 File Offset: 0x002F9708
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
				if (num != 40U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CombinerEntity = input.ReadInt64();
					}
				}
				else
				{
					this.TargetEntity = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007C65 RID: 31845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C66 RID: 31846
		public const int CombinerEntityFieldNumber = 12;

		// Token: 0x04007C67 RID: 31847
		private long combinerEntity_;

		// Token: 0x04007C68 RID: 31848
		public const int TargetEntityFieldNumber = 5;

		// Token: 0x04007C69 RID: 31849
		private long targetEntity_;
	}
}
