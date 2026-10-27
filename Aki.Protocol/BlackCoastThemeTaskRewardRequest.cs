using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A9 RID: 425
	[NetMessage(EMessageId.BlackCoastThemeTaskRewardRequest)]
	public sealed class BlackCoastThemeTaskRewardRequest : IMessage<BlackCoastThemeTaskRewardRequest>, IMessage, IEquatable<BlackCoastThemeTaskRewardRequest>, IDeepCloneable<BlackCoastThemeTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060031CF RID: 12751 RVA: 0x0007ECF1 File Offset: 0x0007CEF1
		[NullableContext(1)]
		public static BlackCoastThemeTaskRewardRequest Create()
		{
			return new BlackCoastThemeTaskRewardRequest();
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x0007ECF8 File Offset: 0x0007CEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x0007ECFB File Offset: 0x0007CEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x0007ED02 File Offset: 0x0007CF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardRequest()
		{
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x0007ED0A File Offset: 0x0007CF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardRequest(BlackCoastThemeTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0007ED2F File Offset: 0x0007CF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardRequest Clone()
		{
			return new BlackCoastThemeTaskRewardRequest(this);
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x0007ED37 File Offset: 0x0007CF37
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x0007ED3F File Offset: 0x0007CF3F
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

		// Token: 0x060031D7 RID: 12759 RVA: 0x0007ED48 File Offset: 0x0007CF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeTaskRewardRequest);
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x0007ED56 File Offset: 0x0007CF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x0007ED84 File Offset: 0x0007CF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x0007EDC3 File Offset: 0x0007CFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x0007EDD0 File Offset: 0x0007CFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0007EDD9 File Offset: 0x0007CFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0007EE0C File Offset: 0x0007D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0007EE4A File Offset: 0x0007D04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0007EE7B File Offset: 0x0007D07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0007EE84 File Offset: 0x0007D084
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400294F RID: 10575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002950 RID: 10576
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04002951 RID: 10577
		private int taskId_;
	}
}
