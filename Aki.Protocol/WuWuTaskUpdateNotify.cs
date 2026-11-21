using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A0 RID: 5536
	[NetMessage(EMessageId.WuWuTaskUpdateNotify)]
	public sealed class WuWuTaskUpdateNotify : IMessage<WuWuTaskUpdateNotify>, IMessage, IEquatable<WuWuTaskUpdateNotify>, IDeepCloneable<WuWuTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601D4E0 RID: 120032 RVA: 0x0043E0D5 File Offset: 0x0043C2D5
		[NullableContext(1)]
		public static WuWuTaskUpdateNotify Create()
		{
			return new WuWuTaskUpdateNotify();
		}

		// Token: 0x17006328 RID: 25384
		// (get) Token: 0x0601D4E1 RID: 120033 RVA: 0x0043E0DC File Offset: 0x0043C2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006329 RID: 25385
		// (get) Token: 0x0601D4E2 RID: 120034 RVA: 0x0043E0DF File Offset: 0x0043C2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601D4E3 RID: 120035 RVA: 0x0043E0E6 File Offset: 0x0043C2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskUpdateNotify()
		{
		}

		// Token: 0x0601D4E4 RID: 120036 RVA: 0x0043E0EE File Offset: 0x0043C2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskUpdateNotify(WuWuTaskUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D4E5 RID: 120037 RVA: 0x0043E123 File Offset: 0x0043C323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskUpdateNotify Clone()
		{
			return new WuWuTaskUpdateNotify(this);
		}

		// Token: 0x1700632A RID: 25386
		// (get) Token: 0x0601D4E6 RID: 120038 RVA: 0x0043E12B File Offset: 0x0043C32B
		// (set) Token: 0x0601D4E7 RID: 120039 RVA: 0x0043E133 File Offset: 0x0043C333
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

		// Token: 0x0601D4E8 RID: 120040 RVA: 0x0043E13C File Offset: 0x0043C33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskUpdateNotify);
		}

		// Token: 0x0601D4E9 RID: 120041 RVA: 0x0043E14A File Offset: 0x0043C34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D4EA RID: 120042 RVA: 0x0043E180 File Offset: 0x0043C380
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

		// Token: 0x0601D4EB RID: 120043 RVA: 0x0043E1BC File Offset: 0x0043C3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D4EC RID: 120044 RVA: 0x0043E1C9 File Offset: 0x0043C3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D4ED RID: 120045 RVA: 0x0043E1D2 File Offset: 0x0043C3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D4EE RID: 120046 RVA: 0x0043E204 File Offset: 0x0043C404
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

		// Token: 0x0601D4EF RID: 120047 RVA: 0x0043E244 File Offset: 0x0043C444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuTaskUpdateNotify other)
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

		// Token: 0x0601D4F0 RID: 120048 RVA: 0x0043E298 File Offset: 0x0043C498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D4F1 RID: 120049 RVA: 0x0043E2A4 File Offset: 0x0043C4A4
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
				if (num != 82U)
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

		// Token: 0x0400A80D RID: 43021
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A80E RID: 43022
		public const int TaskFieldNumber = 10;

		// Token: 0x0400A80F RID: 43023
		private ConditionTask task_;
	}
}
