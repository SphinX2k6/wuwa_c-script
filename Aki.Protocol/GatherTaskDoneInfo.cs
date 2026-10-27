using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BC RID: 1724
	public sealed class GatherTaskDoneInfo : IMessage<GatherTaskDoneInfo>, IMessage, IEquatable<GatherTaskDoneInfo>, IDeepCloneable<GatherTaskDoneInfo>, IBufferMessage
	{
		// Token: 0x06009DE2 RID: 40418 RVA: 0x0017F7B7 File Offset: 0x0017D9B7
		[NullableContext(1)]
		public static GatherTaskDoneInfo Create()
		{
			return new GatherTaskDoneInfo();
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x0017F7BE File Offset: 0x0017D9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GatherTaskDoneInfo> Parser
		{
			get
			{
				return GatherTaskDoneInfo._parser;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06009DE4 RID: 40420 RVA: 0x0017F7C5 File Offset: 0x0017D9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x0017F7C8 File Offset: 0x0017D9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherTaskDoneInfo.Descriptor;
			}
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x0017F7CF File Offset: 0x0017D9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskDoneInfo()
		{
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x0017F7D7 File Offset: 0x0017D9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskDoneInfo(GatherTaskDoneInfo other) : this()
		{
			this.taskId_ = other.taskId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x0017F808 File Offset: 0x0017DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskDoneInfo Clone()
		{
			return new GatherTaskDoneInfo(this);
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06009DE9 RID: 40425 RVA: 0x0017F810 File Offset: 0x0017DA10
		// (set) Token: 0x06009DEA RID: 40426 RVA: 0x0017F818 File Offset: 0x0017DA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06009DEB RID: 40427 RVA: 0x0017F821 File Offset: 0x0017DA21
		// (set) Token: 0x06009DEC RID: 40428 RVA: 0x0017F829 File Offset: 0x0017DA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityTaskState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x0017F832 File Offset: 0x0017DA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherTaskDoneInfo);
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x0017F840 File Offset: 0x0017DA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherTaskDoneInfo other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x0017F880 File Offset: 0x0017DA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.State != GatherActivityTaskState.GatherLock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x0017F8DE File Offset: 0x0017DADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x0017F8EB File Offset: 0x0017DAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x0017F8F4 File Offset: 0x0017DAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.State != GatherActivityTaskState.GatherLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x0017F94C File Offset: 0x0017DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.State != GatherActivityTaskState.GatherLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x0017F9A4 File Offset: 0x0017DBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherTaskDoneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.State != GatherActivityTaskState.GatherLock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x0017F9F4 File Offset: 0x0017DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x0017FA00 File Offset: 0x0017DC00
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (GatherActivityTaskState)input.ReadEnum();
					}
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A10 RID: 18960
		private static readonly MessageParser<GatherTaskDoneInfo> _parser = new MessageParser<GatherTaskDoneInfo>(() => new GatherTaskDoneInfo());

		// Token: 0x04004A11 RID: 18961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A12 RID: 18962
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04004A13 RID: 18963
		private int taskId_;

		// Token: 0x04004A14 RID: 18964
		public const int StateFieldNumber = 2;

		// Token: 0x04004A15 RID: 18965
		private GatherActivityTaskState state_;
	}
}
