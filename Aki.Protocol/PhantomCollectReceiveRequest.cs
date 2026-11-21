using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB5 RID: 3253
	[NetMessage(EMessageId.PhantomCollectReceiveRequest)]
	public sealed class PhantomCollectReceiveRequest : IMessage<PhantomCollectReceiveRequest>, IMessage, IEquatable<PhantomCollectReceiveRequest>, IDeepCloneable<PhantomCollectReceiveRequest>, IBufferMessage
	{
		// Token: 0x06011A31 RID: 72241 RVA: 0x002956C4 File Offset: 0x002938C4
		[NullableContext(1)]
		public static PhantomCollectReceiveRequest Create()
		{
			return new PhantomCollectReceiveRequest();
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x06011A32 RID: 72242 RVA: 0x002956CB File Offset: 0x002938CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x06011A33 RID: 72243 RVA: 0x002956CE File Offset: 0x002938CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06011A34 RID: 72244 RVA: 0x002956D5 File Offset: 0x002938D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveRequest()
		{
		}

		// Token: 0x06011A35 RID: 72245 RVA: 0x002956DD File Offset: 0x002938DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveRequest(PhantomCollectReceiveRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A36 RID: 72246 RVA: 0x0029570E File Offset: 0x0029390E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReceiveRequest Clone()
		{
			return new PhantomCollectReceiveRequest(this);
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x06011A37 RID: 72247 RVA: 0x00295716 File Offset: 0x00293916
		// (set) Token: 0x06011A38 RID: 72248 RVA: 0x0029571E File Offset: 0x0029391E
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

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x06011A39 RID: 72249 RVA: 0x00295727 File Offset: 0x00293927
		// (set) Token: 0x06011A3A RID: 72250 RVA: 0x0029572F File Offset: 0x0029392F
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

		// Token: 0x06011A3B RID: 72251 RVA: 0x00295738 File Offset: 0x00293938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectReceiveRequest);
		}

		// Token: 0x06011A3C RID: 72252 RVA: 0x00295746 File Offset: 0x00293946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectReceiveRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A3D RID: 72253 RVA: 0x00295784 File Offset: 0x00293984
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

		// Token: 0x06011A3E RID: 72254 RVA: 0x002957E2 File Offset: 0x002939E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A3F RID: 72255 RVA: 0x002957EF File Offset: 0x002939EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A40 RID: 72256 RVA: 0x002957F8 File Offset: 0x002939F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Type);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A41 RID: 72257 RVA: 0x00295854 File Offset: 0x00293A54
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

		// Token: 0x06011A42 RID: 72258 RVA: 0x002958AC File Offset: 0x00293AAC
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

		// Token: 0x06011A43 RID: 72259 RVA: 0x002958FC File Offset: 0x00293AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A44 RID: 72260 RVA: 0x00295908 File Offset: 0x00293B08
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
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (PhantomCollectRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F66 RID: 28518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F67 RID: 28519
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04006F68 RID: 28520
		private int activityId_;

		// Token: 0x04006F69 RID: 28521
		public const int TypeFieldNumber = 4;

		// Token: 0x04006F6A RID: 28522
		private PhantomCollectRewardType type_;
	}
}
