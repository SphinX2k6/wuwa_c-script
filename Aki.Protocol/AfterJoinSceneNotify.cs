using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D8 RID: 216
	[NetMessage(EMessageId.AfterJoinSceneNotify)]
	public sealed class AfterJoinSceneNotify : IMessage<AfterJoinSceneNotify>, IMessage, IEquatable<AfterJoinSceneNotify>, IDeepCloneable<AfterJoinSceneNotify>, IBufferMessage
	{
		// Token: 0x060020D0 RID: 8400 RVA: 0x0005871E File Offset: 0x0005691E
		[NullableContext(1)]
		public static AfterJoinSceneNotify Create()
		{
			return new AfterJoinSceneNotify();
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x00058725 File Offset: 0x00056925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00058728 File Offset: 0x00056928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AfterJoinSceneNotify.Descriptor;
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0005872F File Offset: 0x0005692F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AfterJoinSceneNotify()
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00058737 File Offset: 0x00056937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AfterJoinSceneNotify(AfterJoinSceneNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00058750 File Offset: 0x00056950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AfterJoinSceneNotify Clone()
		{
			return new AfterJoinSceneNotify(this);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00058758 File Offset: 0x00056958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AfterJoinSceneNotify);
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00058766 File Offset: 0x00056966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AfterJoinSceneNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00058784 File Offset: 0x00056984
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

		// Token: 0x060020D9 RID: 8409 RVA: 0x000587AA File Offset: 0x000569AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000587B7 File Offset: 0x000569B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000587C0 File Offset: 0x000569C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x000587D8 File Offset: 0x000569D8
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

		// Token: 0x060020DD RID: 8413 RVA: 0x000587FE File Offset: 0x000569FE
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

		// Token: 0x060020DE RID: 8414 RVA: 0x0005881B File Offset: 0x00056A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00058824 File Offset: 0x00056A24
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

		// Token: 0x04002461 RID: 9313
		private UnknownFieldSet _unknownFields;
	}
}
