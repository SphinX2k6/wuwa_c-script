using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000968 RID: 2408
	[NetMessage(EMessageId.LowMemoryChangeSceneFinishResponse)]
	public sealed class LowMemoryChangeSceneFinishResponse : IMessage<LowMemoryChangeSceneFinishResponse>, IMessage, IEquatable<LowMemoryChangeSceneFinishResponse>, IDeepCloneable<LowMemoryChangeSceneFinishResponse>, IBufferMessage
	{
		// Token: 0x0600D414 RID: 54292 RVA: 0x001F3C9E File Offset: 0x001F1E9E
		[NullableContext(1)]
		public static LowMemoryChangeSceneFinishResponse Create()
		{
			return new LowMemoryChangeSceneFinishResponse();
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x0600D415 RID: 54293 RVA: 0x001F3CA5 File Offset: 0x001F1EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x0600D416 RID: 54294 RVA: 0x001F3CA8 File Offset: 0x001F1EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LowMemoryChangeSceneFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600D417 RID: 54295 RVA: 0x001F3CAF File Offset: 0x001F1EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishResponse()
		{
		}

		// Token: 0x0600D418 RID: 54296 RVA: 0x001F3CB7 File Offset: 0x001F1EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishResponse(LowMemoryChangeSceneFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D419 RID: 54297 RVA: 0x001F3CDC File Offset: 0x001F1EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishResponse Clone()
		{
			return new LowMemoryChangeSceneFinishResponse(this);
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x0600D41A RID: 54298 RVA: 0x001F3CE4 File Offset: 0x001F1EE4
		// (set) Token: 0x0600D41B RID: 54299 RVA: 0x001F3CEC File Offset: 0x001F1EEC
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

		// Token: 0x0600D41C RID: 54300 RVA: 0x001F3CF5 File Offset: 0x001F1EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LowMemoryChangeSceneFinishResponse);
		}

		// Token: 0x0600D41D RID: 54301 RVA: 0x001F3D03 File Offset: 0x001F1F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LowMemoryChangeSceneFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D41E RID: 54302 RVA: 0x001F3D34 File Offset: 0x001F1F34
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

		// Token: 0x0600D41F RID: 54303 RVA: 0x001F3D79 File Offset: 0x001F1F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D420 RID: 54304 RVA: 0x001F3D86 File Offset: 0x001F1F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D421 RID: 54305 RVA: 0x001F3D8F File Offset: 0x001F1F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D422 RID: 54306 RVA: 0x001F3DC4 File Offset: 0x001F1FC4
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

		// Token: 0x0600D423 RID: 54307 RVA: 0x001F3E02 File Offset: 0x001F2002
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

		// Token: 0x0600D424 RID: 54308 RVA: 0x001F3E33 File Offset: 0x001F2033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D425 RID: 54309 RVA: 0x001F3E3C File Offset: 0x001F203C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400590C RID: 22796
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400590D RID: 22797
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400590E RID: 22798
		private ErrorCode errorCode_;
	}
}
