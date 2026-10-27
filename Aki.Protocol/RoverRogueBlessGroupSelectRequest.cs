using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F3 RID: 4339
	[NetMessage(EMessageId.RoverRogueBlessGroupSelectRequest)]
	public sealed class RoverRogueBlessGroupSelectRequest : IMessage<RoverRogueBlessGroupSelectRequest>, IMessage, IEquatable<RoverRogueBlessGroupSelectRequest>, IDeepCloneable<RoverRogueBlessGroupSelectRequest>, IBufferMessage
	{
		// Token: 0x0601723B RID: 94779 RVA: 0x0035BBC8 File Offset: 0x00359DC8
		[NullableContext(1)]
		public static RoverRogueBlessGroupSelectRequest Create()
		{
			return new RoverRogueBlessGroupSelectRequest();
		}

		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x0601723C RID: 94780 RVA: 0x0035BBCF File Offset: 0x00359DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x0601723D RID: 94781 RVA: 0x0035BBD2 File Offset: 0x00359DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupSelectRequest.Descriptor;
			}
		}

		// Token: 0x0601723E RID: 94782 RVA: 0x0035BBD9 File Offset: 0x00359DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectRequest()
		{
		}

		// Token: 0x0601723F RID: 94783 RVA: 0x0035BBE1 File Offset: 0x00359DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectRequest(RoverRogueBlessGroupSelectRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.blessGroupId_ = other.blessGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017240 RID: 94784 RVA: 0x0035BC12 File Offset: 0x00359E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectRequest Clone()
		{
			return new RoverRogueBlessGroupSelectRequest(this);
		}

		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x06017241 RID: 94785 RVA: 0x0035BC1A File Offset: 0x00359E1A
		// (set) Token: 0x06017242 RID: 94786 RVA: 0x0035BC22 File Offset: 0x00359E22
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

		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x06017243 RID: 94787 RVA: 0x0035BC2B File Offset: 0x00359E2B
		// (set) Token: 0x06017244 RID: 94788 RVA: 0x0035BC33 File Offset: 0x00359E33
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

		// Token: 0x06017245 RID: 94789 RVA: 0x0035BC3C File Offset: 0x00359E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupSelectRequest);
		}

		// Token: 0x06017246 RID: 94790 RVA: 0x0035BC4A File Offset: 0x00359E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupSelectRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BlessGroupId == other.BlessGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017247 RID: 94791 RVA: 0x0035BC88 File Offset: 0x00359E88
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

		// Token: 0x06017248 RID: 94792 RVA: 0x0035BCE0 File Offset: 0x00359EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017249 RID: 94793 RVA: 0x0035BCED File Offset: 0x00359EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601724A RID: 94794 RVA: 0x0035BCF8 File Offset: 0x00359EF8
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

		// Token: 0x0601724B RID: 94795 RVA: 0x0035BD54 File Offset: 0x00359F54
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

		// Token: 0x0601724C RID: 94796 RVA: 0x0035BDAC File Offset: 0x00359FAC
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

		// Token: 0x0601724D RID: 94797 RVA: 0x0035BDFC File Offset: 0x00359FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601724E RID: 94798 RVA: 0x0035BE08 File Offset: 0x0035A008
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

		// Token: 0x040089A7 RID: 35239
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089A8 RID: 35240
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x040089A9 RID: 35241
		private int activityId_;

		// Token: 0x040089AA RID: 35242
		public const int BlessGroupIdFieldNumber = 5;

		// Token: 0x040089AB RID: 35243
		private int blessGroupId_;
	}
}
