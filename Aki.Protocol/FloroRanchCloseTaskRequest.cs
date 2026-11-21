using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000595 RID: 1429
	[NetMessage(EMessageId.FloroRanchCloseTaskRequest)]
	public sealed class FloroRanchCloseTaskRequest : IMessage<FloroRanchCloseTaskRequest>, IMessage, IEquatable<FloroRanchCloseTaskRequest>, IDeepCloneable<FloroRanchCloseTaskRequest>, IBufferMessage
	{
		// Token: 0x0600849F RID: 33951 RVA: 0x0013F545 File Offset: 0x0013D745
		[NullableContext(1)]
		public static FloroRanchCloseTaskRequest Create()
		{
			return new FloroRanchCloseTaskRequest();
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060084A0 RID: 33952 RVA: 0x0013F54C File Offset: 0x0013D74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x060084A1 RID: 33953 RVA: 0x0013F54F File Offset: 0x0013D74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchCloseTaskRequest.Descriptor;
			}
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x0013F556 File Offset: 0x0013D756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskRequest()
		{
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x0013F55E File Offset: 0x0013D75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskRequest(FloroRanchCloseTaskRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.taskIncId_ = other.taskIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x0013F59B File Offset: 0x0013D79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskRequest Clone()
		{
			return new FloroRanchCloseTaskRequest(this);
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x0013F5A3 File Offset: 0x0013D7A3
		// (set) Token: 0x060084A6 RID: 33958 RVA: 0x0013F5AB File Offset: 0x0013D7AB
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

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060084A7 RID: 33959 RVA: 0x0013F5B4 File Offset: 0x0013D7B4
		// (set) Token: 0x060084A8 RID: 33960 RVA: 0x0013F5BC File Offset: 0x0013D7BC
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

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x060084A9 RID: 33961 RVA: 0x0013F5C5 File Offset: 0x0013D7C5
		// (set) Token: 0x060084AA RID: 33962 RVA: 0x0013F5CD File Offset: 0x0013D7CD
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

		// Token: 0x060084AB RID: 33963 RVA: 0x0013F5D6 File Offset: 0x0013D7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchCloseTaskRequest);
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x0013F5E4 File Offset: 0x0013D7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchCloseTaskRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.TaskIncId == other.TaskIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x0013F640 File Offset: 0x0013D840
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

		// Token: 0x060084AE RID: 33966 RVA: 0x0013F6B1 File Offset: 0x0013D8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x0013F6BE File Offset: 0x0013D8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084B0 RID: 33968 RVA: 0x0013F6C8 File Offset: 0x0013D8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			if (this.TaskIncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TaskIncId);
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

		// Token: 0x060084B1 RID: 33969 RVA: 0x0013F73C File Offset: 0x0013D93C
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

		// Token: 0x060084B2 RID: 33970 RVA: 0x0013F7AC File Offset: 0x0013D9AC
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

		// Token: 0x060084B3 RID: 33971 RVA: 0x0013F810 File Offset: 0x0013DA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x0013F81C File Offset: 0x0013DA1C
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
					if (num != 80U)
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
						this.TaskIncId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400421D RID: 16925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400421E RID: 16926
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x0400421F RID: 16927
		private int activityId_;

		// Token: 0x04004220 RID: 16928
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x04004221 RID: 16929
		private int subInsId_;

		// Token: 0x04004222 RID: 16930
		public const int TaskIncIdFieldNumber = 10;

		// Token: 0x04004223 RID: 16931
		private int taskIncId_;
	}
}
