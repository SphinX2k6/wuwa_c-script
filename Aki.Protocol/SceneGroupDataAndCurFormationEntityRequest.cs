using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001191 RID: 4497
	[NetMessage(EMessageId.SceneGroupDataAndCurFormationEntityRequest)]
	public sealed class SceneGroupDataAndCurFormationEntityRequest : IMessage<SceneGroupDataAndCurFormationEntityRequest>, IMessage, IEquatable<SceneGroupDataAndCurFormationEntityRequest>, IDeepCloneable<SceneGroupDataAndCurFormationEntityRequest>, IBufferMessage
	{
		// Token: 0x06018036 RID: 98358 RVA: 0x0037E698 File Offset: 0x0037C898
		[NullableContext(1)]
		public static SceneGroupDataAndCurFormationEntityRequest Create()
		{
			return new SceneGroupDataAndCurFormationEntityRequest();
		}

		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x06018037 RID: 98359 RVA: 0x0037E69F File Offset: 0x0037C89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x06018038 RID: 98360 RVA: 0x0037E6A2 File Offset: 0x0037C8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGroupDataAndCurFormationEntityRequest.Descriptor;
			}
		}

		// Token: 0x06018039 RID: 98361 RVA: 0x0037E6A9 File Offset: 0x0037C8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityRequest()
		{
		}

		// Token: 0x0601803A RID: 98362 RVA: 0x0037E6B1 File Offset: 0x0037C8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityRequest(SceneGroupDataAndCurFormationEntityRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601803B RID: 98363 RVA: 0x0037E6CA File Offset: 0x0037C8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityRequest Clone()
		{
			return new SceneGroupDataAndCurFormationEntityRequest(this);
		}

		// Token: 0x0601803C RID: 98364 RVA: 0x0037E6D2 File Offset: 0x0037C8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGroupDataAndCurFormationEntityRequest);
		}

		// Token: 0x0601803D RID: 98365 RVA: 0x0037E6E0 File Offset: 0x0037C8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGroupDataAndCurFormationEntityRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601803E RID: 98366 RVA: 0x0037E700 File Offset: 0x0037C900
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

		// Token: 0x0601803F RID: 98367 RVA: 0x0037E726 File Offset: 0x0037C926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018040 RID: 98368 RVA: 0x0037E733 File Offset: 0x0037C933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018041 RID: 98369 RVA: 0x0037E73C File Offset: 0x0037C93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018042 RID: 98370 RVA: 0x0037E754 File Offset: 0x0037C954
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

		// Token: 0x06018043 RID: 98371 RVA: 0x0037E77A File Offset: 0x0037C97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGroupDataAndCurFormationEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018044 RID: 98372 RVA: 0x0037E797 File Offset: 0x0037C997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018045 RID: 98373 RVA: 0x0037E7A0 File Offset: 0x0037C9A0
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

		// Token: 0x04008EFA RID: 36602
		private UnknownFieldSet _unknownFields;
	}
}
