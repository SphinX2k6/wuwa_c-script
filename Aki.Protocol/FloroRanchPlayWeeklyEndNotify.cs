using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D8 RID: 1496
	[NetMessage(EMessageId.FloroRanchPlayWeeklyEndNotify)]
	public sealed class FloroRanchPlayWeeklyEndNotify : IMessage<FloroRanchPlayWeeklyEndNotify>, IMessage, IEquatable<FloroRanchPlayWeeklyEndNotify>, IDeepCloneable<FloroRanchPlayWeeklyEndNotify>, IBufferMessage
	{
		// Token: 0x06008A73 RID: 35443 RVA: 0x0014ECDF File Offset: 0x0014CEDF
		[NullableContext(1)]
		public static FloroRanchPlayWeeklyEndNotify Create()
		{
			return new FloroRanchPlayWeeklyEndNotify();
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06008A74 RID: 35444 RVA: 0x0014ECE6 File Offset: 0x0014CEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06008A75 RID: 35445 RVA: 0x0014ECE9 File Offset: 0x0014CEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayWeeklyEndNotify.Descriptor;
			}
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x0014ECF0 File Offset: 0x0014CEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyEndNotify()
		{
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x0014ECF8 File Offset: 0x0014CEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyEndNotify(FloroRanchPlayWeeklyEndNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x0014ED29 File Offset: 0x0014CF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyEndNotify Clone()
		{
			return new FloroRanchPlayWeeklyEndNotify(this);
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x0014ED31 File Offset: 0x0014CF31
		// (set) Token: 0x06008A7A RID: 35450 RVA: 0x0014ED39 File Offset: 0x0014CF39
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

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06008A7B RID: 35451 RVA: 0x0014ED42 File Offset: 0x0014CF42
		// (set) Token: 0x06008A7C RID: 35452 RVA: 0x0014ED4A File Offset: 0x0014CF4A
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

		// Token: 0x06008A7D RID: 35453 RVA: 0x0014ED53 File Offset: 0x0014CF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayWeeklyEndNotify);
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x0014ED61 File Offset: 0x0014CF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayWeeklyEndNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x0014EDA0 File Offset: 0x0014CFA0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x0014EDF8 File Offset: 0x0014CFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x0014EE05 File Offset: 0x0014D005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x0014EE10 File Offset: 0x0014D010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x0014EE68 File Offset: 0x0014D068
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x0014EEC0 File Offset: 0x0014D0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayWeeklyEndNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A85 RID: 35461 RVA: 0x0014EF10 File Offset: 0x0014D110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x0014EF1C File Offset: 0x0014D11C
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
					if (num != 32U)
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
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004405 RID: 17413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004406 RID: 17414
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04004407 RID: 17415
		private int activityId_;

		// Token: 0x04004408 RID: 17416
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x04004409 RID: 17417
		private int subInsId_;
	}
}
