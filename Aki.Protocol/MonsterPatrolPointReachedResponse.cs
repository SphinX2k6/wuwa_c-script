using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F4 RID: 2548
	[NetMessage(EMessageId.MonsterPatrolPointReachedResponse)]
	public sealed class MonsterPatrolPointReachedResponse : IMessage<MonsterPatrolPointReachedResponse>, IMessage, IEquatable<MonsterPatrolPointReachedResponse>, IDeepCloneable<MonsterPatrolPointReachedResponse>, IBufferMessage
	{
		// Token: 0x0600DF60 RID: 57184 RVA: 0x0020C297 File Offset: 0x0020A497
		[NullableContext(1)]
		public static MonsterPatrolPointReachedResponse Create()
		{
			return new MonsterPatrolPointReachedResponse();
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0600DF61 RID: 57185 RVA: 0x0020C29E File Offset: 0x0020A49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0600DF62 RID: 57186 RVA: 0x0020C2A1 File Offset: 0x0020A4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterPatrolPointReachedResponse.Descriptor;
			}
		}

		// Token: 0x0600DF63 RID: 57187 RVA: 0x0020C2A8 File Offset: 0x0020A4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedResponse()
		{
		}

		// Token: 0x0600DF64 RID: 57188 RVA: 0x0020C2B0 File Offset: 0x0020A4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedResponse(MonsterPatrolPointReachedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF65 RID: 57189 RVA: 0x0020C2D5 File Offset: 0x0020A4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedResponse Clone()
		{
			return new MonsterPatrolPointReachedResponse(this);
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0600DF66 RID: 57190 RVA: 0x0020C2DD File Offset: 0x0020A4DD
		// (set) Token: 0x0600DF67 RID: 57191 RVA: 0x0020C2E5 File Offset: 0x0020A4E5
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

		// Token: 0x0600DF68 RID: 57192 RVA: 0x0020C2EE File Offset: 0x0020A4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterPatrolPointReachedResponse);
		}

		// Token: 0x0600DF69 RID: 57193 RVA: 0x0020C2FC File Offset: 0x0020A4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterPatrolPointReachedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF6A RID: 57194 RVA: 0x0020C32C File Offset: 0x0020A52C
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

		// Token: 0x0600DF6B RID: 57195 RVA: 0x0020C371 File Offset: 0x0020A571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF6C RID: 57196 RVA: 0x0020C37E File Offset: 0x0020A57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x0020C387 File Offset: 0x0020A587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x0020C3BC File Offset: 0x0020A5BC
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

		// Token: 0x0600DF6F RID: 57199 RVA: 0x0020C3FA File Offset: 0x0020A5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterPatrolPointReachedResponse other)
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

		// Token: 0x0600DF70 RID: 57200 RVA: 0x0020C42B File Offset: 0x0020A62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF71 RID: 57201 RVA: 0x0020C434 File Offset: 0x0020A634
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005C70 RID: 23664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C71 RID: 23665
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005C72 RID: 23666
		private ErrorCode errorCode_;
	}
}
