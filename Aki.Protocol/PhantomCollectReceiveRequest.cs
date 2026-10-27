using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC5 RID: 3269
	[NetMessage(EMessageId.PhantomCollectReceiveRequest)]
	public sealed class PhantomCollectReceiveRequest : IMessage<PhantomCollectReceiveRequest>, IMessage, IEquatable<PhantomCollectReceiveRequest>, IDeepCloneable<PhantomCollectReceiveRequest>, IBufferMessage
	{
		// Token: 0x06011B31 RID: 72497 RVA: 0x00297424 File Offset: 0x00295624
		[NullableContext(1)]
		public static PhantomCollectReceiveRequest Create()
		{
			return new PhantomCollectReceiveRequest();
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x06011B32 RID: 72498 RVA: 0x0029742B File Offset: 0x0029562B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x06011B33 RID: 72499 RVA: 0x0029742E File Offset: 0x0029562E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06011B34 RID: 72500 RVA: 0x00297435 File Offset: 0x00295635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveRequest()
		{
		}

		// Token: 0x06011B35 RID: 72501 RVA: 0x0029743D File Offset: 0x0029563D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveRequest(PhantomCollectReceiveRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B36 RID: 72502 RVA: 0x0029746E File Offset: 0x0029566E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveRequest Clone()
		{
			return new PhantomCollectReceiveRequest(this);
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x06011B37 RID: 72503 RVA: 0x00297476 File Offset: 0x00295676
		// (set) Token: 0x06011B38 RID: 72504 RVA: 0x0029747E File Offset: 0x0029567E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x06011B39 RID: 72505 RVA: 0x00297487 File Offset: 0x00295687
		// (set) Token: 0x06011B3A RID: 72506 RVA: 0x0029748F File Offset: 0x0029568F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06011B3B RID: 72507 RVA: 0x00297498 File Offset: 0x00295698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectReceiveRequest);
		}

		// Token: 0x06011B3C RID: 72508 RVA: 0x002974A6 File Offset: 0x002956A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectReceiveRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B3D RID: 72509 RVA: 0x002974E4 File Offset: 0x002956E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B3E RID: 72510 RVA: 0x00297542 File Offset: 0x00295742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B3F RID: 72511 RVA: 0x0029754F File Offset: 0x0029574F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B40 RID: 72512 RVA: 0x00297558 File Offset: 0x00295758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B41 RID: 72513 RVA: 0x002975B4 File Offset: 0x002957B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B42 RID: 72514 RVA: 0x0029760C File Offset: 0x0029580C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B43 RID: 72515 RVA: 0x0029765C File Offset: 0x0029585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B44 RID: 72516 RVA: 0x00297668 File Offset: 0x00295868
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (PhantomCollectRewardType)input.ReadEnum();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F52 RID: 28498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F53 RID: 28499
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04006F54 RID: 28500
		private int activityId_;

		// Token: 0x04006F55 RID: 28501
		public const int TypeFieldNumber = 5;

		// Token: 0x04006F56 RID: 28502
		private PhantomCollectRewardType type_;
	}
}
