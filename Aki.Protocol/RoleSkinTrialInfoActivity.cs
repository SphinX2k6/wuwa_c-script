using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C0 RID: 4288
	public sealed class RoleSkinTrialInfoActivity : IMessage<RoleSkinTrialInfoActivity>, IMessage, IEquatable<RoleSkinTrialInfoActivity>, IDeepCloneable<RoleSkinTrialInfoActivity>, IBufferMessage
	{
		// Token: 0x06016E31 RID: 93745 RVA: 0x00352EA3 File Offset: 0x003510A3
		[NullableContext(1)]
		public static RoleSkinTrialInfoActivity Create()
		{
			return new RoleSkinTrialInfoActivity();
		}

		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x06016E32 RID: 93746 RVA: 0x00352EAA File Offset: 0x003510AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x06016E33 RID: 93747 RVA: 0x00352EAD File Offset: 0x003510AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialInfoActivity.Descriptor;
			}
		}

		// Token: 0x06016E34 RID: 93748 RVA: 0x00352EB4 File Offset: 0x003510B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialInfoActivity()
		{
		}

		// Token: 0x06016E35 RID: 93749 RVA: 0x00352EC7 File Offset: 0x003510C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialInfoActivity(RoleSkinTrialInfoActivity other) : this()
		{
			this.roleSkinTrialTask_ = other.roleSkinTrialTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E36 RID: 93750 RVA: 0x00352EF1 File Offset: 0x003510F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialInfoActivity Clone()
		{
			return new RoleSkinTrialInfoActivity(this);
		}

		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x06016E37 RID: 93751 RVA: 0x00352EF9 File Offset: 0x003510F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkinTrialTask> RoleSkinTrialTask
		{
			get
			{
				return this.roleSkinTrialTask_;
			}
		}

		// Token: 0x06016E38 RID: 93752 RVA: 0x00352F01 File Offset: 0x00351101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialInfoActivity);
		}

		// Token: 0x06016E39 RID: 93753 RVA: 0x00352F0F File Offset: 0x0035110F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialInfoActivity other)
		{
			return other != null && (other == this || (this.roleSkinTrialTask_.Equals(other.roleSkinTrialTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E3A RID: 93754 RVA: 0x00352F44 File Offset: 0x00351144
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

		// Token: 0x06016E3B RID: 93755 RVA: 0x00352F78 File Offset: 0x00351178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E3C RID: 93756 RVA: 0x00352F85 File Offset: 0x00351185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E3D RID: 93757 RVA: 0x00352F8E File Offset: 0x0035118E
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

		// Token: 0x06016E3E RID: 93758 RVA: 0x00352FB8 File Offset: 0x003511B8
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

		// Token: 0x06016E3F RID: 93759 RVA: 0x00352FF1 File Offset: 0x003511F1
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

		// Token: 0x06016E40 RID: 93760 RVA: 0x0035301F File Offset: 0x0035121F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E41 RID: 93761 RVA: 0x00353028 File Offset: 0x00351228
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

		// Token: 0x04008876 RID: 34934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008877 RID: 34935
		public const int RoleSkinTrialTaskFieldNumber = 1;

		// Token: 0x04008878 RID: 34936
		private static readonly FieldCodec<RoleSkinTrialTask> _repeated_roleSkinTrialTask_codec = FieldCodec.ForMessage<RoleSkinTrialTask>(10U, Aki.Protocol.RoleSkinTrialTask.Parser);

		// Token: 0x04008879 RID: 34937
		private readonly RepeatedField<RoleSkinTrialTask> roleSkinTrialTask_ = new RepeatedField<RoleSkinTrialTask>();
	}
}
