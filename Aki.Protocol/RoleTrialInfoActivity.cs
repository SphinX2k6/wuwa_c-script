using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001104 RID: 4356
	public sealed class RoleTrialInfoActivity : IMessage<RoleTrialInfoActivity>, IMessage, IEquatable<RoleTrialInfoActivity>, IDeepCloneable<RoleTrialInfoActivity>, IBufferMessage
	{
		// Token: 0x06017491 RID: 95377 RVA: 0x0036387B File Offset: 0x00361A7B
		[NullableContext(1)]
		public static RoleTrialInfoActivity Create()
		{
			return new RoleTrialInfoActivity();
		}

		// Token: 0x17004E3C RID: 20028
		// (get) Token: 0x06017492 RID: 95378 RVA: 0x00363882 File Offset: 0x00361A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x06017493 RID: 95379 RVA: 0x00363885 File Offset: 0x00361A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialInfoActivity.Descriptor;
			}
		}

		// Token: 0x06017494 RID: 95380 RVA: 0x0036388C File Offset: 0x00361A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialInfoActivity()
		{
		}

		// Token: 0x06017495 RID: 95381 RVA: 0x0036389F File Offset: 0x00361A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialInfoActivity(RoleTrialInfoActivity other) : this()
		{
			this.roleTrialTask_ = other.roleTrialTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017496 RID: 95382 RVA: 0x003638C9 File Offset: 0x00361AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialInfoActivity Clone()
		{
			return new RoleTrialInfoActivity(this);
		}

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x06017497 RID: 95383 RVA: 0x003638D1 File Offset: 0x00361AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTrialTask> RoleTrialTask
		{
			get
			{
				return this.roleTrialTask_;
			}
		}

		// Token: 0x06017498 RID: 95384 RVA: 0x003638D9 File Offset: 0x00361AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialInfoActivity);
		}

		// Token: 0x06017499 RID: 95385 RVA: 0x003638E7 File Offset: 0x00361AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialInfoActivity other)
		{
			return other != null && (other == this || (this.roleTrialTask_.Equals(other.roleTrialTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601749A RID: 95386 RVA: 0x0036391C File Offset: 0x00361B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleTrialTask_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601749B RID: 95387 RVA: 0x00363950 File Offset: 0x00361B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601749C RID: 95388 RVA: 0x0036395D File Offset: 0x00361B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601749D RID: 95389 RVA: 0x00363966 File Offset: 0x00361B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleTrialTask_.WriteTo(ref output, RoleTrialInfoActivity._repeated_roleTrialTask_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601749E RID: 95390 RVA: 0x00363990 File Offset: 0x00361B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleTrialTask_.CalculateSize(RoleTrialInfoActivity._repeated_roleTrialTask_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601749F RID: 95391 RVA: 0x003639C9 File Offset: 0x00361BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialInfoActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.roleTrialTask_.Add(other.roleTrialTask_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060174A0 RID: 95392 RVA: 0x003639F7 File Offset: 0x00361BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174A1 RID: 95393 RVA: 0x00363A00 File Offset: 0x00361C00
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleTrialTask_.AddEntriesFrom(ref input, RoleTrialInfoActivity._repeated_roleTrialTask_codec);
				}
			}
		}

		// Token: 0x04008B36 RID: 35638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B37 RID: 35639
		public const int RoleTrialTaskFieldNumber = 1;

		// Token: 0x04008B38 RID: 35640
		private static readonly FieldCodec<RoleTrialTask> _repeated_roleTrialTask_codec = FieldCodec.ForMessage<RoleTrialTask>(10U, Aki.Protocol.RoleTrialTask.Parser);

		// Token: 0x04008B39 RID: 35641
		private readonly RepeatedField<RoleTrialTask> roleTrialTask_ = new RepeatedField<RoleTrialTask>();
	}
}
