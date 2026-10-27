using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D7 RID: 215
	[NetMessage(EMessageId.AfterJoinSceneNotify)]
	public sealed class AfterJoinSceneNotify : IMessage<AfterJoinSceneNotify>, IMessage, IEquatable<AfterJoinSceneNotify>, IDeepCloneable<AfterJoinSceneNotify>, IBufferMessage
	{
		// Token: 0x06002087 RID: 8327 RVA: 0x00057A6A File Offset: 0x00055C6A
		[NullableContext(1)]
		public static AfterJoinSceneNotify Create()
		{
			return new AfterJoinSceneNotify();
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x00057A71 File Offset: 0x00055C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x00057A74 File Offset: 0x00055C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AfterJoinSceneNotify.Descriptor;
			}
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00057A7B File Offset: 0x00055C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AfterJoinSceneNotify()
		{
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00057A83 File Offset: 0x00055C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AfterJoinSceneNotify(AfterJoinSceneNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00057A9C File Offset: 0x00055C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AfterJoinSceneNotify Clone()
		{
			return new AfterJoinSceneNotify(this);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00057AA4 File Offset: 0x00055CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AfterJoinSceneNotify);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00057AB2 File Offset: 0x00055CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AfterJoinSceneNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00057AD0 File Offset: 0x00055CD0
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

		// Token: 0x06002090 RID: 8336 RVA: 0x00057AF6 File Offset: 0x00055CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00057B03 File Offset: 0x00055D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00057B0C File Offset: 0x00055D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00057B24 File Offset: 0x00055D24
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

		// Token: 0x06002094 RID: 8340 RVA: 0x00057B4A File Offset: 0x00055D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AfterJoinSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00057B67 File Offset: 0x00055D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00057B70 File Offset: 0x00055D70
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

		// Token: 0x040023FE RID: 9214
		private UnknownFieldSet _unknownFields;
	}
}
