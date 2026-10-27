using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001169 RID: 4457
	[NetMessage(EMessageId.SceneItemMoveSplineResponse)]
	public sealed class SceneItemMoveSplineResponse : IMessage<SceneItemMoveSplineResponse>, IMessage, IEquatable<SceneItemMoveSplineResponse>, IDeepCloneable<SceneItemMoveSplineResponse>, IBufferMessage
	{
		// Token: 0x06017C39 RID: 97337 RVA: 0x00373C08 File Offset: 0x00371E08
		[NullableContext(1)]
		public static SceneItemMoveSplineResponse Create()
		{
			return new SceneItemMoveSplineResponse();
		}

		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x06017C3A RID: 97338 RVA: 0x00373C0F File Offset: 0x00371E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x06017C3B RID: 97339 RVA: 0x00373C12 File Offset: 0x00371E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveSplineResponse.Descriptor;
			}
		}

		// Token: 0x06017C3C RID: 97340 RVA: 0x00373C19 File Offset: 0x00371E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineResponse()
		{
		}

		// Token: 0x06017C3D RID: 97341 RVA: 0x00373C21 File Offset: 0x00371E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineResponse(SceneItemMoveSplineResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C3E RID: 97342 RVA: 0x00373C46 File Offset: 0x00371E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineResponse Clone()
		{
			return new SceneItemMoveSplineResponse(this);
		}

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x06017C3F RID: 97343 RVA: 0x00373C4E File Offset: 0x00371E4E
		// (set) Token: 0x06017C40 RID: 97344 RVA: 0x00373C56 File Offset: 0x00371E56
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

		// Token: 0x06017C41 RID: 97345 RVA: 0x00373C5F File Offset: 0x00371E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveSplineResponse);
		}

		// Token: 0x06017C42 RID: 97346 RVA: 0x00373C6D File Offset: 0x00371E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveSplineResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C43 RID: 97347 RVA: 0x00373C9C File Offset: 0x00371E9C
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

		// Token: 0x06017C44 RID: 97348 RVA: 0x00373CE1 File Offset: 0x00371EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C45 RID: 97349 RVA: 0x00373CEE File Offset: 0x00371EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C46 RID: 97350 RVA: 0x00373CF7 File Offset: 0x00371EF7
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

		// Token: 0x06017C47 RID: 97351 RVA: 0x00373D2C File Offset: 0x00371F2C
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

		// Token: 0x06017C48 RID: 97352 RVA: 0x00373D6A File Offset: 0x00371F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveSplineResponse other)
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

		// Token: 0x06017C49 RID: 97353 RVA: 0x00373D9B File Offset: 0x00371F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C4A RID: 97354 RVA: 0x00373DA4 File Offset: 0x00371FA4
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

		// Token: 0x04008D04 RID: 36100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D05 RID: 36101
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008D06 RID: 36102
		private ErrorCode errorCode_;
	}
}
