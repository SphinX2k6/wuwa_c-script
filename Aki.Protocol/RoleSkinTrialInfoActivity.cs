using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B0 RID: 4272
	public sealed class RoleSkinTrialInfoActivity : IMessage<RoleSkinTrialInfoActivity>, IMessage, IEquatable<RoleSkinTrialInfoActivity>, IDeepCloneable<RoleSkinTrialInfoActivity>, IBufferMessage
	{
		// Token: 0x06016D4C RID: 93516 RVA: 0x003517C7 File Offset: 0x0034F9C7
		[NullableContext(1)]
		public static RoleSkinTrialInfoActivity Create()
		{
			return new RoleSkinTrialInfoActivity();
		}

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x06016D4D RID: 93517 RVA: 0x003517CE File Offset: 0x0034F9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x06016D4E RID: 93518 RVA: 0x003517D1 File Offset: 0x0034F9D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialInfoActivity.Descriptor;
			}
		}

		// Token: 0x06016D4F RID: 93519 RVA: 0x003517D8 File Offset: 0x0034F9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialInfoActivity()
		{
		}

		// Token: 0x06016D50 RID: 93520 RVA: 0x003517EB File Offset: 0x0034F9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialInfoActivity(RoleSkinTrialInfoActivity other) : this()
		{
			this.roleSkinTrialTask_ = other.roleSkinTrialTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D51 RID: 93521 RVA: 0x00351815 File Offset: 0x0034FA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialInfoActivity Clone()
		{
			return new RoleSkinTrialInfoActivity(this);
		}

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x06016D52 RID: 93522 RVA: 0x0035181D File Offset: 0x0034FA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkinTrialTask> RoleSkinTrialTask
		{
			get
			{
				return this.roleSkinTrialTask_;
			}
		}

		// Token: 0x06016D53 RID: 93523 RVA: 0x00351825 File Offset: 0x0034FA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialInfoActivity);
		}

		// Token: 0x06016D54 RID: 93524 RVA: 0x00351833 File Offset: 0x0034FA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialInfoActivity other)
		{
			return other != null && (other == this || (this.roleSkinTrialTask_.Equals(other.roleSkinTrialTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D55 RID: 93525 RVA: 0x00351868 File Offset: 0x0034FA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleSkinTrialTask_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016D56 RID: 93526 RVA: 0x0035189C File Offset: 0x0034FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D57 RID: 93527 RVA: 0x003518A9 File Offset: 0x0034FAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D58 RID: 93528 RVA: 0x003518B2 File Offset: 0x0034FAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleSkinTrialTask_.WriteTo(ref output, RoleSkinTrialInfoActivity._repeated_roleSkinTrialTask_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D59 RID: 93529 RVA: 0x003518DC File Offset: 0x0034FADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleSkinTrialTask_.CalculateSize(RoleSkinTrialInfoActivity._repeated_roleSkinTrialTask_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016D5A RID: 93530 RVA: 0x00351915 File Offset: 0x0034FB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinTrialInfoActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.roleSkinTrialTask_.Add(other.roleSkinTrialTask_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D5B RID: 93531 RVA: 0x00351943 File Offset: 0x0034FB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D5C RID: 93532 RVA: 0x0035194C File Offset: 0x0034FB4C
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
					this.roleSkinTrialTask_.AddEntriesFrom(ref input, RoleSkinTrialInfoActivity._repeated_roleSkinTrialTask_codec);
				}
			}
		}

		// Token: 0x040088A0 RID: 34976
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088A1 RID: 34977
		public const int RoleSkinTrialTaskFieldNumber = 1;

		// Token: 0x040088A2 RID: 34978
		private static readonly FieldCodec<RoleSkinTrialTask> _repeated_roleSkinTrialTask_codec = FieldCodec.ForMessage<RoleSkinTrialTask>(10U, Aki.Protocol.RoleSkinTrialTask.Parser);

		// Token: 0x040088A3 RID: 34979
		private readonly RepeatedField<RoleSkinTrialTask> roleSkinTrialTask_ = new RepeatedField<RoleSkinTrialTask>();
	}
}
