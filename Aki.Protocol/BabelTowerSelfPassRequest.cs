using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000152 RID: 338
	[NetMessage(EMessageId.BabelTowerSelfPassRequest)]
	public sealed class BabelTowerSelfPassRequest : IMessage<BabelTowerSelfPassRequest>, IMessage, IEquatable<BabelTowerSelfPassRequest>, IDeepCloneable<BabelTowerSelfPassRequest>, IBufferMessage
	{
		// Token: 0x06002B36 RID: 11062 RVA: 0x0007131D File Offset: 0x0006F51D
		[NullableContext(1)]
		public static BabelTowerSelfPassRequest Create()
		{
			return new BabelTowerSelfPassRequest();
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x00071324 File Offset: 0x0006F524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x00071327 File Offset: 0x0006F527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSelfPassRequest.Descriptor;
			}
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0007132E File Offset: 0x0006F52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassRequest()
		{
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x00071336 File Offset: 0x0006F536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassRequest(BabelTowerSelfPassRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x0007135B File Offset: 0x0006F55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassRequest Clone()
		{
			return new BabelTowerSelfPassRequest(this);
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x00071363 File Offset: 0x0006F563
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x0007136B File Offset: 0x0006F56B
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

		// Token: 0x06002B3E RID: 11070 RVA: 0x00071374 File Offset: 0x0006F574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSelfPassRequest);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x00071382 File Offset: 0x0006F582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSelfPassRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000713B0 File Offset: 0x0006F5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000713EF File Offset: 0x0006F5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000713FC File Offset: 0x0006F5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00071405 File Offset: 0x0006F605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00071438 File Offset: 0x0006F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00071476 File Offset: 0x0006F676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerSelfPassRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000714A7 File Offset: 0x0006F6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000714B0 File Offset: 0x0006F6B0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040027ED RID: 10221
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027EE RID: 10222
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040027EF RID: 10223
		private int activityId_;
	}
}
