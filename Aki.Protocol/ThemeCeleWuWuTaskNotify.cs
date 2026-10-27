using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001359 RID: 4953
	[NetMessage(EMessageId.ThemeCeleWuWuTaskNotify)]
	public sealed class ThemeCeleWuWuTaskNotify : IMessage<ThemeCeleWuWuTaskNotify>, IMessage, IEquatable<ThemeCeleWuWuTaskNotify>, IDeepCloneable<ThemeCeleWuWuTaskNotify>, IBufferMessage
	{
		// Token: 0x0601A509 RID: 107785 RVA: 0x003D2BE5 File Offset: 0x003D0DE5
		[NullableContext(1)]
		public static ThemeCeleWuWuTaskNotify Create()
		{
			return new ThemeCeleWuWuTaskNotify();
		}

		// Token: 0x170058CC RID: 22732
		// (get) Token: 0x0601A50A RID: 107786 RVA: 0x003D2BEC File Offset: 0x003D0DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058CD RID: 22733
		// (get) Token: 0x0601A50B RID: 107787 RVA: 0x003D2BEF File Offset: 0x003D0DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeCeleWuWuTaskNotify.Descriptor;
			}
		}

		// Token: 0x0601A50C RID: 107788 RVA: 0x003D2BF6 File Offset: 0x003D0DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCeleWuWuTaskNotify()
		{
		}

		// Token: 0x0601A50D RID: 107789 RVA: 0x003D2BFE File Offset: 0x003D0DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCeleWuWuTaskNotify(ThemeCeleWuWuTaskNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A50E RID: 107790 RVA: 0x003D2C33 File Offset: 0x003D0E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCeleWuWuTaskNotify Clone()
		{
			return new ThemeCeleWuWuTaskNotify(this);
		}

		// Token: 0x170058CE RID: 22734
		// (get) Token: 0x0601A50F RID: 107791 RVA: 0x003D2C3B File Offset: 0x003D0E3B
		// (set) Token: 0x0601A510 RID: 107792 RVA: 0x003D2C43 File Offset: 0x003D0E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0601A511 RID: 107793 RVA: 0x003D2C4C File Offset: 0x003D0E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeCeleWuWuTaskNotify);
		}

		// Token: 0x0601A512 RID: 107794 RVA: 0x003D2C5A File Offset: 0x003D0E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeCeleWuWuTaskNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A513 RID: 107795 RVA: 0x003D2C90 File Offset: 0x003D0E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A514 RID: 107796 RVA: 0x003D2CCC File Offset: 0x003D0ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A515 RID: 107797 RVA: 0x003D2CD9 File Offset: 0x003D0ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A516 RID: 107798 RVA: 0x003D2CE2 File Offset: 0x003D0EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A517 RID: 107799 RVA: 0x003D2D14 File Offset: 0x003D0F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A518 RID: 107800 RVA: 0x003D2D54 File Offset: 0x003D0F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeCeleWuWuTaskNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A519 RID: 107801 RVA: 0x003D2DA8 File Offset: 0x003D0FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A51A RID: 107802 RVA: 0x003D2DB4 File Offset: 0x003D0FB4
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.task_ == null)
					{
						this.Task = new ConditionTask();
					}
					input.ReadMessage(this.Task);
				}
			}
		}

		// Token: 0x04009974 RID: 39284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009975 RID: 39285
		public const int TaskFieldNumber = 15;

		// Token: 0x04009976 RID: 39286
		private ConditionTask task_;
	}
}
