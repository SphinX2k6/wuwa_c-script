using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CA RID: 4298
	public sealed class RoleTrialInfoActivity : IMessage<RoleTrialInfoActivity>, IMessage, IEquatable<RoleTrialInfoActivity>, IDeepCloneable<RoleTrialInfoActivity>, IBufferMessage
	{
		// Token: 0x06016EF2 RID: 93938 RVA: 0x003545BF File Offset: 0x003527BF
		[NullableContext(1)]
		public static RoleTrialInfoActivity Create()
		{
			return new RoleTrialInfoActivity();
		}

		// Token: 0x17004CD1 RID: 19665
		// (get) Token: 0x06016EF3 RID: 93939 RVA: 0x003545C6 File Offset: 0x003527C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CD2 RID: 19666
		// (get) Token: 0x06016EF4 RID: 93940 RVA: 0x003545C9 File Offset: 0x003527C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialInfoActivity.Descriptor;
			}
		}

		// Token: 0x06016EF5 RID: 93941 RVA: 0x003545D0 File Offset: 0x003527D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialInfoActivity()
		{
		}

		// Token: 0x06016EF6 RID: 93942 RVA: 0x003545E3 File Offset: 0x003527E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialInfoActivity(RoleTrialInfoActivity other) : this()
		{
			this.roleTrialTask_ = other.roleTrialTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EF7 RID: 93943 RVA: 0x0035460D File Offset: 0x0035280D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialInfoActivity Clone()
		{
			return new RoleTrialInfoActivity(this);
		}

		// Token: 0x17004CD3 RID: 19667
		// (get) Token: 0x06016EF8 RID: 93944 RVA: 0x00354615 File Offset: 0x00352815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTrialTask> RoleTrialTask
		{
			get
			{
				return this.roleTrialTask_;
			}
		}

		// Token: 0x06016EF9 RID: 93945 RVA: 0x0035461D File Offset: 0x0035281D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialInfoActivity);
		}

		// Token: 0x06016EFA RID: 93946 RVA: 0x0035462B File Offset: 0x0035282B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialInfoActivity other)
		{
			return other != null && (other == this || (this.roleTrialTask_.Equals(other.roleTrialTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EFB RID: 93947 RVA: 0x00354660 File Offset: 0x00352860
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

		// Token: 0x06016EFC RID: 93948 RVA: 0x00354694 File Offset: 0x00352894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EFD RID: 93949 RVA: 0x003546A1 File Offset: 0x003528A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EFE RID: 93950 RVA: 0x003546AA File Offset: 0x003528AA
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

		// Token: 0x06016EFF RID: 93951 RVA: 0x003546D4 File Offset: 0x003528D4
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

		// Token: 0x06016F00 RID: 93952 RVA: 0x0035470D File Offset: 0x0035290D
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

		// Token: 0x06016F01 RID: 93953 RVA: 0x0035473B File Offset: 0x0035293B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F02 RID: 93954 RVA: 0x00354744 File Offset: 0x00352944
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

		// Token: 0x040088A5 RID: 34981
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088A6 RID: 34982
		public const int RoleTrialTaskFieldNumber = 1;

		// Token: 0x040088A7 RID: 34983
		private static readonly FieldCodec<RoleTrialTask> _repeated_roleTrialTask_codec = FieldCodec.ForMessage<RoleTrialTask>(10U, Aki.Protocol.RoleTrialTask.Parser);

		// Token: 0x040088A8 RID: 34984
		private readonly RepeatedField<RoleTrialTask> roleTrialTask_ = new RepeatedField<RoleTrialTask>();
	}
}
