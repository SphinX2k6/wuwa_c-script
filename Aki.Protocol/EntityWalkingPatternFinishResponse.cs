using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CE RID: 1230
	[NetMessage(EMessageId.EntityWalkingPatternFinishResponse)]
	public sealed class EntityWalkingPatternFinishResponse : IMessage<EntityWalkingPatternFinishResponse>, IMessage, IEquatable<EntityWalkingPatternFinishResponse>, IDeepCloneable<EntityWalkingPatternFinishResponse>, IBufferMessage
	{
		// Token: 0x060074E4 RID: 29924 RVA: 0x0011E6DB File Offset: 0x0011C8DB
		[NullableContext(1)]
		public static EntityWalkingPatternFinishResponse Create()
		{
			return new EntityWalkingPatternFinishResponse();
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x0011E6E2 File Offset: 0x0011C8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x060074E6 RID: 29926 RVA: 0x0011E6E5 File Offset: 0x0011C8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityWalkingPatternFinishResponse.Descriptor;
			}
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x0011E6EC File Offset: 0x0011C8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishResponse()
		{
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x0011E6F4 File Offset: 0x0011C8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishResponse(EntityWalkingPatternFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x0011E719 File Offset: 0x0011C919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishResponse Clone()
		{
			return new EntityWalkingPatternFinishResponse(this);
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x060074EA RID: 29930 RVA: 0x0011E721 File Offset: 0x0011C921
		// (set) Token: 0x060074EB RID: 29931 RVA: 0x0011E729 File Offset: 0x0011C929
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

		// Token: 0x060074EC RID: 29932 RVA: 0x0011E732 File Offset: 0x0011C932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityWalkingPatternFinishResponse);
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x0011E740 File Offset: 0x0011C940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityWalkingPatternFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x0011E770 File Offset: 0x0011C970
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

		// Token: 0x060074EF RID: 29935 RVA: 0x0011E7B5 File Offset: 0x0011C9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x0011E7C2 File Offset: 0x0011C9C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x0011E7CB File Offset: 0x0011C9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x0011E800 File Offset: 0x0011CA00
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

		// Token: 0x060074F3 RID: 29939 RVA: 0x0011E83E File Offset: 0x0011CA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityWalkingPatternFinishResponse other)
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

		// Token: 0x060074F4 RID: 29940 RVA: 0x0011E86F File Offset: 0x0011CA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x0011E878 File Offset: 0x0011CA78
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D8F RID: 15759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D90 RID: 15760
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003D91 RID: 15761
		private ErrorCode errorCode_;
	}
}
