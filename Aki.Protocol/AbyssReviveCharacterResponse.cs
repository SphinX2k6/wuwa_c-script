using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003C RID: 60
	[NetMessage(EMessageId.AbyssReviveCharacterResponse)]
	public sealed class AbyssReviveCharacterResponse : IMessage<AbyssReviveCharacterResponse>, IMessage, IEquatable<AbyssReviveCharacterResponse>, IDeepCloneable<AbyssReviveCharacterResponse>, IBufferMessage
	{
		// Token: 0x06001340 RID: 4928 RVA: 0x000345FB File Offset: 0x000327FB
		[NullableContext(1)]
		public static AbyssReviveCharacterResponse Create()
		{
			return new AbyssReviveCharacterResponse();
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00034602 File Offset: 0x00032802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x00034605 File Offset: 0x00032805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveCharacterResponse.Descriptor;
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0003460C File Offset: 0x0003280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterResponse()
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00034614 File Offset: 0x00032814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterResponse(AbyssReviveCharacterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00034639 File Offset: 0x00032839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterResponse Clone()
		{
			return new AbyssReviveCharacterResponse(this);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x00034641 File Offset: 0x00032841
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00034649 File Offset: 0x00032849
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

		// Token: 0x06001348 RID: 4936 RVA: 0x00034652 File Offset: 0x00032852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveCharacterResponse);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00034660 File Offset: 0x00032860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveCharacterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00034690 File Offset: 0x00032890
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

		// Token: 0x0600134B RID: 4939 RVA: 0x000346D5 File Offset: 0x000328D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x000346E2 File Offset: 0x000328E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000346EB File Offset: 0x000328EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00034720 File Offset: 0x00032920
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

		// Token: 0x0600134F RID: 4943 RVA: 0x0003475E File Offset: 0x0003295E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssReviveCharacterResponse other)
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

		// Token: 0x06001350 RID: 4944 RVA: 0x0003478F File Offset: 0x0003298F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00034798 File Offset: 0x00032998
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002004 RID: 8196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002005 RID: 8197
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002006 RID: 8198
		private ErrorCode errorCode_;
	}
}
