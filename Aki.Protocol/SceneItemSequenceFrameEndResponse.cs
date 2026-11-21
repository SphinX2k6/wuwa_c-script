using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AA RID: 4522
	[NetMessage(EMessageId.SceneItemSequenceFrameEndResponse)]
	public sealed class SceneItemSequenceFrameEndResponse : IMessage<SceneItemSequenceFrameEndResponse>, IMessage, IEquatable<SceneItemSequenceFrameEndResponse>, IDeepCloneable<SceneItemSequenceFrameEndResponse>, IBufferMessage
	{
		// Token: 0x0601826A RID: 98922 RVA: 0x00384414 File Offset: 0x00382614
		[NullableContext(1)]
		public static SceneItemSequenceFrameEndResponse Create()
		{
			return new SceneItemSequenceFrameEndResponse();
		}

		// Token: 0x1700515F RID: 20831
		// (get) Token: 0x0601826B RID: 98923 RVA: 0x0038441B File Offset: 0x0038261B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005160 RID: 20832
		// (get) Token: 0x0601826C RID: 98924 RVA: 0x0038441E File Offset: 0x0038261E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameEndResponse.Descriptor;
			}
		}

		// Token: 0x0601826D RID: 98925 RVA: 0x00384425 File Offset: 0x00382625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndResponse()
		{
		}

		// Token: 0x0601826E RID: 98926 RVA: 0x0038442D File Offset: 0x0038262D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndResponse(SceneItemSequenceFrameEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601826F RID: 98927 RVA: 0x00384452 File Offset: 0x00382652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameEndResponse Clone()
		{
			return new SceneItemSequenceFrameEndResponse(this);
		}

		// Token: 0x17005161 RID: 20833
		// (get) Token: 0x06018270 RID: 98928 RVA: 0x0038445A File Offset: 0x0038265A
		// (set) Token: 0x06018271 RID: 98929 RVA: 0x00384462 File Offset: 0x00382662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06018272 RID: 98930 RVA: 0x0038446B File Offset: 0x0038266B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameEndResponse);
		}

		// Token: 0x06018273 RID: 98931 RVA: 0x00384479 File Offset: 0x00382679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018274 RID: 98932 RVA: 0x003844A8 File Offset: 0x003826A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018275 RID: 98933 RVA: 0x003844ED File Offset: 0x003826ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018276 RID: 98934 RVA: 0x003844FA File Offset: 0x003826FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018277 RID: 98935 RVA: 0x00384503 File Offset: 0x00382703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018278 RID: 98936 RVA: 0x00384538 File Offset: 0x00382738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018279 RID: 98937 RVA: 0x00384576 File Offset: 0x00382776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSequenceFrameEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601827A RID: 98938 RVA: 0x003845A7 File Offset: 0x003827A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601827B RID: 98939 RVA: 0x003845B0 File Offset: 0x003827B0
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FBE RID: 36798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FBF RID: 36799
		public const int CodeFieldNumber = 8;

		// Token: 0x04008FC0 RID: 36800
		private ErrorCode code_;
	}
}
