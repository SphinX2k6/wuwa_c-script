using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E2 RID: 1506
	[NetMessage(EMessageId.FlowEndNotify)]
	public sealed class FlowEndNotify : IMessage<FlowEndNotify>, IMessage, IEquatable<FlowEndNotify>, IDeepCloneable<FlowEndNotify>, IBufferMessage
	{
		// Token: 0x06008BF2 RID: 35826 RVA: 0x00154139 File Offset: 0x00152339
		[NullableContext(1)]
		public static FlowEndNotify Create()
		{
			return new FlowEndNotify();
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06008BF3 RID: 35827 RVA: 0x00154140 File Offset: 0x00152340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06008BF4 RID: 35828 RVA: 0x00154143 File Offset: 0x00152343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowEndNotify.Descriptor;
			}
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x0015414A File Offset: 0x0015234A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndNotify()
		{
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x00154152 File Offset: 0x00152352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndNotify(FlowEndNotify other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.async_ = other.async_;
			this.isFinished_ = other.isFinished_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x0015418F File Offset: 0x0015238F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndNotify Clone()
		{
			return new FlowEndNotify(this);
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x00154197 File Offset: 0x00152397
		// (set) Token: 0x06008BF9 RID: 35833 RVA: 0x0015419F File Offset: 0x0015239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowIncId
		{
			get
			{
				return this.flowIncId_;
			}
			set
			{
				this.flowIncId_ = value;
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06008BFA RID: 35834 RVA: 0x001541A8 File Offset: 0x001523A8
		// (set) Token: 0x06008BFB RID: 35835 RVA: 0x001541B0 File Offset: 0x001523B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Async
		{
			get
			{
				return this.async_;
			}
			set
			{
				this.async_ = value;
			}
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x001541B9 File Offset: 0x001523B9
		// (set) Token: 0x06008BFD RID: 35837 RVA: 0x001541C1 File Offset: 0x001523C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x001541CA File Offset: 0x001523CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowEndNotify);
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x001541D8 File Offset: 0x001523D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowEndNotify other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.Async == other.Async && this.IsFinished == other.IsFinished && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x00154234 File Offset: 0x00152434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this.Async)
			{
				num ^= this.Async.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x001542A5 File Offset: 0x001524A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x001542B2 File Offset: 0x001524B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x001542BC File Offset: 0x001524BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.Async)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Async);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsFinished);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x00154334 File Offset: 0x00152534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this.Async)
			{
				num += 2;
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x0015438C File Offset: 0x0015258C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			if (other.Async)
			{
				this.Async = other.Async;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x001543F0 File Offset: 0x001525F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x001543FC File Offset: 0x001525FC
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
				if (num != 56U)
				{
					if (num != 64U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsFinished = input.ReadBool();
						}
					}
					else
					{
						this.Async = input.ReadBool();
					}
				}
				else
				{
					this.FlowIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040044FC RID: 17660
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044FD RID: 17661
		public const int FlowIncIdFieldNumber = 7;

		// Token: 0x040044FE RID: 17662
		private long flowIncId_;

		// Token: 0x040044FF RID: 17663
		public const int AsyncFieldNumber = 8;

		// Token: 0x04004500 RID: 17664
		private bool async_;

		// Token: 0x04004501 RID: 17665
		public const int IsFinishedFieldNumber = 14;

		// Token: 0x04004502 RID: 17666
		private bool isFinished_;
	}
}
