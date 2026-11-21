using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C2 RID: 1474
	[NetMessage(EMessageId.FloroRanchPlayUnlimitedModeResponse)]
	public sealed class FloroRanchPlayUnlimitedModeResponse : IMessage<FloroRanchPlayUnlimitedModeResponse>, IMessage, IEquatable<FloroRanchPlayUnlimitedModeResponse>, IDeepCloneable<FloroRanchPlayUnlimitedModeResponse>, IBufferMessage
	{
		// Token: 0x060088F5 RID: 35061 RVA: 0x0014BD5F File Offset: 0x00149F5F
		[NullableContext(1)]
		public static FloroRanchPlayUnlimitedModeResponse Create()
		{
			return new FloroRanchPlayUnlimitedModeResponse();
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060088F6 RID: 35062 RVA: 0x0014BD66 File Offset: 0x00149F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060088F7 RID: 35063 RVA: 0x0014BD69 File Offset: 0x00149F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayUnlimitedModeResponse.Descriptor;
			}
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x0014BD70 File Offset: 0x00149F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeResponse()
		{
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x0014BD84 File Offset: 0x00149F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeResponse(FloroRanchPlayUnlimitedModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.curStage_ = other.curStage_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x0014BDD1 File Offset: 0x00149FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeResponse Clone()
		{
			return new FloroRanchPlayUnlimitedModeResponse(this);
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060088FB RID: 35067 RVA: 0x0014BDD9 File Offset: 0x00149FD9
		// (set) Token: 0x060088FC RID: 35068 RVA: 0x0014BDE1 File Offset: 0x00149FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x060088FD RID: 35069 RVA: 0x0014BDEA File Offset: 0x00149FEA
		// (set) Token: 0x060088FE RID: 35070 RVA: 0x0014BDF2 File Offset: 0x00149FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStage
		{
			get
			{
				return this.curStage_;
			}
			set
			{
				this.curStage_ = value;
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x060088FF RID: 35071 RVA: 0x0014BDFB File Offset: 0x00149FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x0014BE03 File Offset: 0x0014A003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayUnlimitedModeResponse);
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x0014BE14 File Offset: 0x0014A014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayUnlimitedModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CurStage == other.CurStage && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x0014BE74 File Offset: 0x0014A074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CurStage != 0)
			{
				num ^= this.CurStage.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x0014BEE0 File Offset: 0x0014A0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x0014BEED File Offset: 0x0014A0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008905 RID: 35077 RVA: 0x0014BEF8 File Offset: 0x0014A0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, FloroRanchPlayUnlimitedModeResponse._repeated_task_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurStage != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurStage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008906 RID: 35078 RVA: 0x0014BF64 File Offset: 0x0014A164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CurStage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStage);
			}
			num += this.task_.CalculateSize(FloroRanchPlayUnlimitedModeResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008907 RID: 35079 RVA: 0x0014BFD0 File Offset: 0x0014A1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayUnlimitedModeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CurStage != 0)
			{
				this.CurStage = other.CurStage;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008908 RID: 35080 RVA: 0x0014C031 File Offset: 0x0014A231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x0014C03C File Offset: 0x0014A23C
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
				if (num != 98U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurStage = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, FloroRanchPlayUnlimitedModeResponse._repeated_task_codec);
				}
			}
		}

		// Token: 0x040043F3 RID: 17395
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043F4 RID: 17396
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040043F5 RID: 17397
		private ErrorCode errorCode_;

		// Token: 0x040043F6 RID: 17398
		public const int CurStageFieldNumber = 15;

		// Token: 0x040043F7 RID: 17399
		private int curStage_;

		// Token: 0x040043F8 RID: 17400
		public const int TaskFieldNumber = 12;

		// Token: 0x040043F9 RID: 17401
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(98U, FloroRanchPlayTask.Parser);

		// Token: 0x040043FA RID: 17402
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
