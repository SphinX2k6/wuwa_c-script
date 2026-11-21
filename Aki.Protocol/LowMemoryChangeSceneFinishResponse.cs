using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000957 RID: 2391
	[NetMessage(EMessageId.LowMemoryChangeSceneFinishResponse)]
	public sealed class LowMemoryChangeSceneFinishResponse : IMessage<LowMemoryChangeSceneFinishResponse>, IMessage, IEquatable<LowMemoryChangeSceneFinishResponse>, IDeepCloneable<LowMemoryChangeSceneFinishResponse>, IBufferMessage
	{
		// Token: 0x0600D2FA RID: 54010 RVA: 0x001F1AB6 File Offset: 0x001EFCB6
		[NullableContext(1)]
		public static LowMemoryChangeSceneFinishResponse Create()
		{
			return new LowMemoryChangeSceneFinishResponse();
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x0600D2FB RID: 54011 RVA: 0x001F1ABD File Offset: 0x001EFCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x0600D2FC RID: 54012 RVA: 0x001F1AC0 File Offset: 0x001EFCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LowMemoryChangeSceneFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600D2FD RID: 54013 RVA: 0x001F1AC7 File Offset: 0x001EFCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishResponse()
		{
		}

		// Token: 0x0600D2FE RID: 54014 RVA: 0x001F1ACF File Offset: 0x001EFCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishResponse(LowMemoryChangeSceneFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2FF RID: 54015 RVA: 0x001F1AF4 File Offset: 0x001EFCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishResponse Clone()
		{
			return new LowMemoryChangeSceneFinishResponse(this);
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x0600D300 RID: 54016 RVA: 0x001F1AFC File Offset: 0x001EFCFC
		// (set) Token: 0x0600D301 RID: 54017 RVA: 0x001F1B04 File Offset: 0x001EFD04
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

		// Token: 0x0600D302 RID: 54018 RVA: 0x001F1B0D File Offset: 0x001EFD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LowMemoryChangeSceneFinishResponse);
		}

		// Token: 0x0600D303 RID: 54019 RVA: 0x001F1B1B File Offset: 0x001EFD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LowMemoryChangeSceneFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D304 RID: 54020 RVA: 0x001F1B4C File Offset: 0x001EFD4C
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

		// Token: 0x0600D305 RID: 54021 RVA: 0x001F1B91 File Offset: 0x001EFD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D306 RID: 54022 RVA: 0x001F1B9E File Offset: 0x001EFD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D307 RID: 54023 RVA: 0x001F1BA7 File Offset: 0x001EFDA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x001F1BDC File Offset: 0x001EFDDC
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

		// Token: 0x0600D309 RID: 54025 RVA: 0x001F1C1A File Offset: 0x001EFE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LowMemoryChangeSceneFinishResponse other)
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

		// Token: 0x0600D30A RID: 54026 RVA: 0x001F1C4B File Offset: 0x001EFE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D30B RID: 54027 RVA: 0x001F1C54 File Offset: 0x001EFE54
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005915 RID: 22805
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005916 RID: 22806
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005917 RID: 22807
		private ErrorCode errorCode_;
	}
}
