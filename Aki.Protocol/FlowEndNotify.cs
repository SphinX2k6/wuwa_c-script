using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F7 RID: 1527
	[NetMessage(EMessageId.FlowEndNotify)]
	public sealed class FlowEndNotify : IMessage<FlowEndNotify>, IMessage, IEquatable<FlowEndNotify>, IDeepCloneable<FlowEndNotify>, IBufferMessage
	{
		// Token: 0x06008D5A RID: 36186 RVA: 0x00156D3D File Offset: 0x00154F3D
		[NullableContext(1)]
		public static FlowEndNotify Create()
		{
			return new FlowEndNotify();
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06008D5B RID: 36187 RVA: 0x00156D44 File Offset: 0x00154F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06008D5C RID: 36188 RVA: 0x00156D47 File Offset: 0x00154F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowEndNotify.Descriptor;
			}
		}

		// Token: 0x06008D5D RID: 36189 RVA: 0x00156D4E File Offset: 0x00154F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndNotify()
		{
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x00156D56 File Offset: 0x00154F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndNotify(FlowEndNotify other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.async_ = other.async_;
			this.isFinished_ = other.isFinished_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x00156D93 File Offset: 0x00154F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndNotify Clone()
		{
			return new FlowEndNotify(this);
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06008D60 RID: 36192 RVA: 0x00156D9B File Offset: 0x00154F9B
		// (set) Token: 0x06008D61 RID: 36193 RVA: 0x00156DA3 File Offset: 0x00154FA3
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

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06008D62 RID: 36194 RVA: 0x00156DAC File Offset: 0x00154FAC
		// (set) Token: 0x06008D63 RID: 36195 RVA: 0x00156DB4 File Offset: 0x00154FB4
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

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06008D64 RID: 36196 RVA: 0x00156DBD File Offset: 0x00154FBD
		// (set) Token: 0x06008D65 RID: 36197 RVA: 0x00156DC5 File Offset: 0x00154FC5
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

		// Token: 0x06008D66 RID: 36198 RVA: 0x00156DCE File Offset: 0x00154FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowEndNotify);
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x00156DDC File Offset: 0x00154FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowEndNotify other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.Async == other.Async && this.IsFinished == other.IsFinished && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x00156E38 File Offset: 0x00155038
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

		// Token: 0x06008D69 RID: 36201 RVA: 0x00156EA9 File Offset: 0x001550A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x00156EB6 File Offset: 0x001550B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x00156EC0 File Offset: 0x001550C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsFinished);
			}
			if (this.Async)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Async);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x00156F34 File Offset: 0x00155134
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

		// Token: 0x06008D6D RID: 36205 RVA: 0x00156F8C File Offset: 0x0015518C
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

		// Token: 0x06008D6E RID: 36206 RVA: 0x00156FF0 File Offset: 0x001551F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x00156FFC File Offset: 0x001551FC
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
					if (num != 40U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Async = input.ReadBool();
						}
					}
					else
					{
						this.IsFinished = input.ReadBool();
					}
				}
				else
				{
					this.FlowIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004506 RID: 17670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004507 RID: 17671
		public const int FlowIncIdFieldNumber = 1;

		// Token: 0x04004508 RID: 17672
		private long flowIncId_;

		// Token: 0x04004509 RID: 17673
		public const int AsyncFieldNumber = 7;

		// Token: 0x0400450A RID: 17674
		private bool async_;

		// Token: 0x0400450B RID: 17675
		public const int IsFinishedFieldNumber = 5;

		// Token: 0x0400450C RID: 17676
		private bool isFinished_;
	}
}
