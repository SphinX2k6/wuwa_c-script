using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001188 RID: 4488
	public sealed class SceneStepConditionProgress : IMessage<SceneStepConditionProgress>, IMessage, IEquatable<SceneStepConditionProgress>, IDeepCloneable<SceneStepConditionProgress>, IBufferMessage
	{
		// Token: 0x06017EC2 RID: 97986 RVA: 0x003797D2 File Offset: 0x003779D2
		[NullableContext(1)]
		public static SceneStepConditionProgress Create()
		{
			return new SceneStepConditionProgress();
		}

		// Token: 0x17005060 RID: 20576
		// (get) Token: 0x06017EC3 RID: 97987 RVA: 0x003797D9 File Offset: 0x003779D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepConditionProgress> Parser
		{
			get
			{
				return SceneStepConditionProgress._parser;
			}
		}

		// Token: 0x17005061 RID: 20577
		// (get) Token: 0x06017EC4 RID: 97988 RVA: 0x003797E0 File Offset: 0x003779E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005062 RID: 20578
		// (get) Token: 0x06017EC5 RID: 97989 RVA: 0x003797E3 File Offset: 0x003779E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepConditionProgress.Descriptor;
			}
		}

		// Token: 0x06017EC6 RID: 97990 RVA: 0x003797EA File Offset: 0x003779EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepConditionProgress()
		{
		}

		// Token: 0x06017EC7 RID: 97991 RVA: 0x003797F2 File Offset: 0x003779F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepConditionProgress(SceneStepConditionProgress other) : this()
		{
			this.conditionId_ = other.conditionId_;
			this.progressNum_ = other.progressNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EC8 RID: 97992 RVA: 0x00379823 File Offset: 0x00377A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepConditionProgress Clone()
		{
			return new SceneStepConditionProgress(this);
		}

		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x06017EC9 RID: 97993 RVA: 0x0037982B File Offset: 0x00377A2B
		// (set) Token: 0x06017ECA RID: 97994 RVA: 0x00379833 File Offset: 0x00377A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionId
		{
			get
			{
				return this.conditionId_;
			}
			set
			{
				this.conditionId_ = value;
			}
		}

		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x06017ECB RID: 97995 RVA: 0x0037983C File Offset: 0x00377A3C
		// (set) Token: 0x06017ECC RID: 97996 RVA: 0x00379844 File Offset: 0x00377A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ProgressNum
		{
			get
			{
				return this.progressNum_;
			}
			set
			{
				this.progressNum_ = value;
			}
		}

		// Token: 0x06017ECD RID: 97997 RVA: 0x0037984D File Offset: 0x00377A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepConditionProgress);
		}

		// Token: 0x06017ECE RID: 97998 RVA: 0x0037985B File Offset: 0x00377A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepConditionProgress other)
		{
			return other != null && (other == this || (this.ConditionId == other.ConditionId && this.ProgressNum == other.ProgressNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017ECF RID: 97999 RVA: 0x0037989C File Offset: 0x00377A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionId != 0)
			{
				num ^= this.ConditionId.GetHashCode();
			}
			if (this.ProgressNum != 0)
			{
				num ^= this.ProgressNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017ED0 RID: 98000 RVA: 0x003798F4 File Offset: 0x00377AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017ED1 RID: 98001 RVA: 0x00379901 File Offset: 0x00377B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017ED2 RID: 98002 RVA: 0x0037990C File Offset: 0x00377B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionId);
			}
			if (this.ProgressNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ProgressNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017ED3 RID: 98003 RVA: 0x00379964 File Offset: 0x00377B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionId);
			}
			if (this.ProgressNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProgressNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017ED4 RID: 98004 RVA: 0x003799BC File Offset: 0x00377BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepConditionProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionId != 0)
			{
				this.ConditionId = other.ConditionId;
			}
			if (other.ProgressNum != 0)
			{
				this.ProgressNum = other.ProgressNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017ED5 RID: 98005 RVA: 0x00379A0C File Offset: 0x00377C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017ED6 RID: 98006 RVA: 0x00379A18 File Offset: 0x00377C18
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
						this.ProgressNum = input.ReadInt32();
					}
				}
				else
				{
					this.ConditionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008DBC RID: 36284
		private static readonly MessageParser<SceneStepConditionProgress> _parser = new MessageParser<SceneStepConditionProgress>(() => new SceneStepConditionProgress());

		// Token: 0x04008DBD RID: 36285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DBE RID: 36286
		public const int ConditionIdFieldNumber = 1;

		// Token: 0x04008DBF RID: 36287
		private int conditionId_;

		// Token: 0x04008DC0 RID: 36288
		public const int ProgressNumFieldNumber = 2;

		// Token: 0x04008DC1 RID: 36289
		private int progressNum_;
	}
}
