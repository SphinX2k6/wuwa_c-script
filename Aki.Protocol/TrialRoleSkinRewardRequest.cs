using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001469 RID: 5225
	[NetMessage(EMessageId.TrialRoleSkinRewardRequest)]
	public sealed class TrialRoleSkinRewardRequest : IMessage<TrialRoleSkinRewardRequest>, IMessage, IEquatable<TrialRoleSkinRewardRequest>, IDeepCloneable<TrialRoleSkinRewardRequest>, IBufferMessage
	{
		// Token: 0x0601BAA3 RID: 113315 RVA: 0x004011A5 File Offset: 0x003FF3A5
		[NullableContext(1)]
		public static TrialRoleSkinRewardRequest Create()
		{
			return new TrialRoleSkinRewardRequest();
		}

		// Token: 0x17005D4D RID: 23885
		// (get) Token: 0x0601BAA4 RID: 113316 RVA: 0x004011AC File Offset: 0x003FF3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D4E RID: 23886
		// (get) Token: 0x0601BAA5 RID: 113317 RVA: 0x004011AF File Offset: 0x003FF3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleSkinRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601BAA6 RID: 113318 RVA: 0x004011B6 File Offset: 0x003FF3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardRequest()
		{
		}

		// Token: 0x0601BAA7 RID: 113319 RVA: 0x004011BE File Offset: 0x003FF3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardRequest(TrialRoleSkinRewardRequest other) : this()
		{
			this.roleSkinTrialInfoId_ = other.roleSkinTrialInfoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAA8 RID: 113320 RVA: 0x004011E3 File Offset: 0x003FF3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardRequest Clone()
		{
			return new TrialRoleSkinRewardRequest(this);
		}

		// Token: 0x17005D4F RID: 23887
		// (get) Token: 0x0601BAA9 RID: 113321 RVA: 0x004011EB File Offset: 0x003FF3EB
		// (set) Token: 0x0601BAAA RID: 113322 RVA: 0x004011F3 File Offset: 0x003FF3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinTrialInfoId
		{
			get
			{
				return this.roleSkinTrialInfoId_;
			}
			set
			{
				this.roleSkinTrialInfoId_ = value;
			}
		}

		// Token: 0x0601BAAB RID: 113323 RVA: 0x004011FC File Offset: 0x003FF3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleSkinRewardRequest);
		}

		// Token: 0x0601BAAC RID: 113324 RVA: 0x0040120A File Offset: 0x003FF40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleSkinRewardRequest other)
		{
			return other != null && (other == this || (this.RoleSkinTrialInfoId == other.RoleSkinTrialInfoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAAD RID: 113325 RVA: 0x00401238 File Offset: 0x003FF438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinTrialInfoId != 0)
			{
				num ^= this.RoleSkinTrialInfoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BAAE RID: 113326 RVA: 0x00401277 File Offset: 0x003FF477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAAF RID: 113327 RVA: 0x00401284 File Offset: 0x003FF484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAB0 RID: 113328 RVA: 0x0040128D File Offset: 0x003FF48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinTrialInfoId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleSkinTrialInfoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAB1 RID: 113329 RVA: 0x004012C0 File Offset: 0x003FF4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinTrialInfoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinTrialInfoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BAB2 RID: 113330 RVA: 0x004012FE File Offset: 0x003FF4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleSkinRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinTrialInfoId != 0)
			{
				this.RoleSkinTrialInfoId = other.RoleSkinTrialInfoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BAB3 RID: 113331 RVA: 0x0040132F File Offset: 0x003FF52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BAB4 RID: 113332 RVA: 0x00401338 File Offset: 0x003FF538
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleSkinTrialInfoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F6F RID: 40815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F70 RID: 40816
		public const int RoleSkinTrialInfoIdFieldNumber = 11;

		// Token: 0x04009F71 RID: 40817
		private int roleSkinTrialInfoId_;
	}
}
