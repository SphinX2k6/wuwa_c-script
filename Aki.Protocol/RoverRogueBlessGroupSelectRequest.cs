using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112D RID: 4397
	[NetMessage(EMessageId.RoverRogueBlessGroupSelectRequest)]
	public sealed class RoverRogueBlessGroupSelectRequest : IMessage<RoverRogueBlessGroupSelectRequest>, IMessage, IEquatable<RoverRogueBlessGroupSelectRequest>, IDeepCloneable<RoverRogueBlessGroupSelectRequest>, IBufferMessage
	{
		// Token: 0x060177DC RID: 96220 RVA: 0x0036AF20 File Offset: 0x00369120
		[NullableContext(1)]
		public static RoverRogueBlessGroupSelectRequest Create()
		{
			return new RoverRogueBlessGroupSelectRequest();
		}

		// Token: 0x17004EF3 RID: 20211
		// (get) Token: 0x060177DD RID: 96221 RVA: 0x0036AF27 File Offset: 0x00369127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EF4 RID: 20212
		// (get) Token: 0x060177DE RID: 96222 RVA: 0x0036AF2A File Offset: 0x0036912A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupSelectRequest.Descriptor;
			}
		}

		// Token: 0x060177DF RID: 96223 RVA: 0x0036AF31 File Offset: 0x00369131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectRequest()
		{
		}

		// Token: 0x060177E0 RID: 96224 RVA: 0x0036AF39 File Offset: 0x00369139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectRequest(RoverRogueBlessGroupSelectRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.blessGroupId_ = other.blessGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177E1 RID: 96225 RVA: 0x0036AF6A File Offset: 0x0036916A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectRequest Clone()
		{
			return new RoverRogueBlessGroupSelectRequest(this);
		}

		// Token: 0x17004EF5 RID: 20213
		// (get) Token: 0x060177E2 RID: 96226 RVA: 0x0036AF72 File Offset: 0x00369172
		// (set) Token: 0x060177E3 RID: 96227 RVA: 0x0036AF7A File Offset: 0x0036917A
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

		// Token: 0x17004EF6 RID: 20214
		// (get) Token: 0x060177E4 RID: 96228 RVA: 0x0036AF83 File Offset: 0x00369183
		// (set) Token: 0x060177E5 RID: 96229 RVA: 0x0036AF8B File Offset: 0x0036918B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlessGroupId
		{
			get
			{
				return this.blessGroupId_;
			}
			set
			{
				this.blessGroupId_ = value;
			}
		}

		// Token: 0x060177E6 RID: 96230 RVA: 0x0036AF94 File Offset: 0x00369194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupSelectRequest);
		}

		// Token: 0x060177E7 RID: 96231 RVA: 0x0036AFA2 File Offset: 0x003691A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupSelectRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BlessGroupId == other.BlessGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177E8 RID: 96232 RVA: 0x0036AFE0 File Offset: 0x003691E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.BlessGroupId != 0)
			{
				num ^= this.BlessGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060177E9 RID: 96233 RVA: 0x0036B038 File Offset: 0x00369238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177EA RID: 96234 RVA: 0x0036B045 File Offset: 0x00369245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177EB RID: 96235 RVA: 0x0036B050 File Offset: 0x00369250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BlessGroupId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BlessGroupId);
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

		// Token: 0x060177EC RID: 96236 RVA: 0x0036B0AC File Offset: 0x003692AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.BlessGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlessGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060177ED RID: 96237 RVA: 0x0036B104 File Offset: 0x00369304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueBlessGroupSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.BlessGroupId != 0)
			{
				this.BlessGroupId = other.BlessGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060177EE RID: 96238 RVA: 0x0036B154 File Offset: 0x00369354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177EF RID: 96239 RVA: 0x0036B160 File Offset: 0x00369360
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
					this.BlessGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C3A RID: 35898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C3B RID: 35899
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04008C3C RID: 35900
		private int activityId_;

		// Token: 0x04008C3D RID: 35901
		public const int BlessGroupIdFieldNumber = 5;

		// Token: 0x04008C3E RID: 35902
		private int blessGroupId_;
	}
}
