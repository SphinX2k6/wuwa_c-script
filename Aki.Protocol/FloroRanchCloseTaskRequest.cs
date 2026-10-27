using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AA RID: 1450
	[NetMessage(EMessageId.FloroRanchCloseTaskRequest)]
	public sealed class FloroRanchCloseTaskRequest : IMessage<FloroRanchCloseTaskRequest>, IMessage, IEquatable<FloroRanchCloseTaskRequest>, IDeepCloneable<FloroRanchCloseTaskRequest>, IBufferMessage
	{
		// Token: 0x06008607 RID: 34311 RVA: 0x0014214D File Offset: 0x0014034D
		[NullableContext(1)]
		public static FloroRanchCloseTaskRequest Create()
		{
			return new FloroRanchCloseTaskRequest();
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06008608 RID: 34312 RVA: 0x00142154 File Offset: 0x00140354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x00142157 File Offset: 0x00140357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchCloseTaskRequest.Descriptor;
			}
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x0014215E File Offset: 0x0014035E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskRequest()
		{
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x00142166 File Offset: 0x00140366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskRequest(FloroRanchCloseTaskRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.taskIncId_ = other.taskIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600860C RID: 34316 RVA: 0x001421A3 File Offset: 0x001403A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskRequest Clone()
		{
			return new FloroRanchCloseTaskRequest(this);
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x0600860D RID: 34317 RVA: 0x001421AB File Offset: 0x001403AB
		// (set) Token: 0x0600860E RID: 34318 RVA: 0x001421B3 File Offset: 0x001403B3
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

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x0600860F RID: 34319 RVA: 0x001421BC File Offset: 0x001403BC
		// (set) Token: 0x06008610 RID: 34320 RVA: 0x001421C4 File Offset: 0x001403C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06008611 RID: 34321 RVA: 0x001421CD File Offset: 0x001403CD
		// (set) Token: 0x06008612 RID: 34322 RVA: 0x001421D5 File Offset: 0x001403D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskIncId
		{
			get
			{
				return this.taskIncId_;
			}
			set
			{
				this.taskIncId_ = value;
			}
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x001421DE File Offset: 0x001403DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchCloseTaskRequest);
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x001421EC File Offset: 0x001403EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchCloseTaskRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.TaskIncId == other.TaskIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008615 RID: 34325 RVA: 0x00142248 File Offset: 0x00140448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.TaskIncId != 0)
			{
				num ^= this.TaskIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x001422B9 File Offset: 0x001404B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x001422C6 File Offset: 0x001404C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x001422D0 File Offset: 0x001404D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubInsId);
			}
			if (this.TaskIncId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TaskIncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008619 RID: 34329 RVA: 0x00142348 File Offset: 0x00140548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.TaskIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600861A RID: 34330 RVA: 0x001423B8 File Offset: 0x001405B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchCloseTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.TaskIncId != 0)
			{
				this.TaskIncId = other.TaskIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600861B RID: 34331 RVA: 0x0014241C File Offset: 0x0014061C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600861C RID: 34332 RVA: 0x00142428 File Offset: 0x00140628
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
					if (num != 64U)
					{
						if (num != 80U)
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
						this.TaskIncId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004227 RID: 16935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004228 RID: 16936
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04004229 RID: 16937
		private int activityId_;

		// Token: 0x0400422A RID: 16938
		public const int SubInsIdFieldNumber = 5;

		// Token: 0x0400422B RID: 16939
		private int subInsId_;

		// Token: 0x0400422C RID: 16940
		public const int TaskIncIdFieldNumber = 8;

		// Token: 0x0400422D RID: 16941
		private int taskIncId_;
	}
}
