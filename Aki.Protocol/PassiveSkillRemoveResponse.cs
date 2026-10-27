using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD6 RID: 3030
	[NetMessage(EMessageId.PassiveSkillRemoveResponse)]
	public sealed class PassiveSkillRemoveResponse : IMessage<PassiveSkillRemoveResponse>, IMessage, IEquatable<PassiveSkillRemoveResponse>, IDeepCloneable<PassiveSkillRemoveResponse>, IBufferMessage
	{
		// Token: 0x06010687 RID: 67207 RVA: 0x00264638 File Offset: 0x00262838
		[NullableContext(1)]
		public static PassiveSkillRemoveResponse Create()
		{
			return new PassiveSkillRemoveResponse();
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x06010688 RID: 67208 RVA: 0x0026463F File Offset: 0x0026283F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x06010689 RID: 67209 RVA: 0x00264642 File Offset: 0x00262842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemoveResponse.Descriptor;
			}
		}

		// Token: 0x0601068A RID: 67210 RVA: 0x00264649 File Offset: 0x00262849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveResponse()
		{
		}

		// Token: 0x0601068B RID: 67211 RVA: 0x00264651 File Offset: 0x00262851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveResponse(PassiveSkillRemoveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601068C RID: 67212 RVA: 0x00264676 File Offset: 0x00262876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveResponse Clone()
		{
			return new PassiveSkillRemoveResponse(this);
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0601068D RID: 67213 RVA: 0x0026467E File Offset: 0x0026287E
		// (set) Token: 0x0601068E RID: 67214 RVA: 0x00264686 File Offset: 0x00262886
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

		// Token: 0x0601068F RID: 67215 RVA: 0x0026468F File Offset: 0x0026288F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemoveResponse);
		}

		// Token: 0x06010690 RID: 67216 RVA: 0x0026469D File Offset: 0x0026289D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemoveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010691 RID: 67217 RVA: 0x002646CC File Offset: 0x002628CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010692 RID: 67218 RVA: 0x00264711 File Offset: 0x00262911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010693 RID: 67219 RVA: 0x0026471E File Offset: 0x0026291E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010694 RID: 67220 RVA: 0x00264727 File Offset: 0x00262927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010695 RID: 67221 RVA: 0x0026475C File Offset: 0x0026295C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010696 RID: 67222 RVA: 0x0026479A File Offset: 0x0026299A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillRemoveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010697 RID: 67223 RVA: 0x002647CB File Offset: 0x002629CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010698 RID: 67224 RVA: 0x002647D4 File Offset: 0x002629D4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006815 RID: 26645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006816 RID: 26646
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04006817 RID: 26647
		private ErrorCode errorCode_;
	}
}
