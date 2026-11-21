using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B9 RID: 4537
	[NetMessage(EMessageId.SceneLoadingTimeOutNotify)]
	public sealed class SceneLoadingTimeOutNotify : IMessage<SceneLoadingTimeOutNotify>, IMessage, IEquatable<SceneLoadingTimeOutNotify>, IDeepCloneable<SceneLoadingTimeOutNotify>, IBufferMessage
	{
		// Token: 0x06018390 RID: 99216 RVA: 0x00386909 File Offset: 0x00384B09
		[NullableContext(1)]
		public static SceneLoadingTimeOutNotify Create()
		{
			return new SceneLoadingTimeOutNotify();
		}

		// Token: 0x17005198 RID: 20888
		// (get) Token: 0x06018391 RID: 99217 RVA: 0x00386910 File Offset: 0x00384B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005199 RID: 20889
		// (get) Token: 0x06018392 RID: 99218 RVA: 0x00386913 File Offset: 0x00384B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingTimeOutNotify.Descriptor;
			}
		}

		// Token: 0x06018393 RID: 99219 RVA: 0x0038691A File Offset: 0x00384B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingTimeOutNotify()
		{
		}

		// Token: 0x06018394 RID: 99220 RVA: 0x00386922 File Offset: 0x00384B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingTimeOutNotify(SceneLoadingTimeOutNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018395 RID: 99221 RVA: 0x0038693B File Offset: 0x00384B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingTimeOutNotify Clone()
		{
			return new SceneLoadingTimeOutNotify(this);
		}

		// Token: 0x06018396 RID: 99222 RVA: 0x00386943 File Offset: 0x00384B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingTimeOutNotify);
		}

		// Token: 0x06018397 RID: 99223 RVA: 0x00386951 File Offset: 0x00384B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingTimeOutNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018398 RID: 99224 RVA: 0x00386970 File Offset: 0x00384B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018399 RID: 99225 RVA: 0x00386996 File Offset: 0x00384B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601839A RID: 99226 RVA: 0x003869A3 File Offset: 0x00384BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601839B RID: 99227 RVA: 0x003869AC File Offset: 0x00384BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601839C RID: 99228 RVA: 0x003869C4 File Offset: 0x00384BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601839D RID: 99229 RVA: 0x003869EA File Offset: 0x00384BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneLoadingTimeOutNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601839E RID: 99230 RVA: 0x00386A07 File Offset: 0x00384C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601839F RID: 99231 RVA: 0x00386A10 File Offset: 0x00384C10
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009003 RID: 36867
		private UnknownFieldSet _unknownFields;
	}
}
