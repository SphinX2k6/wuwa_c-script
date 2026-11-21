using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001073 RID: 4211
	[NetMessage(EMessageId.RoleGoDownPush)]
	public sealed class RoleGoDownPush : IMessage<RoleGoDownPush>, IMessage, IEquatable<RoleGoDownPush>, IDeepCloneable<RoleGoDownPush>, IBufferMessage
	{
		// Token: 0x0601685D RID: 92253 RVA: 0x0034682D File Offset: 0x00344A2D
		[NullableContext(1)]
		public static RoleGoDownPush Create()
		{
			return new RoleGoDownPush();
		}

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x0601685E RID: 92254 RVA: 0x00346834 File Offset: 0x00344A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x0601685F RID: 92255 RVA: 0x00346837 File Offset: 0x00344A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGoDownPush.Descriptor;
			}
		}

		// Token: 0x06016860 RID: 92256 RVA: 0x0034683E File Offset: 0x00344A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownPush()
		{
		}

		// Token: 0x06016861 RID: 92257 RVA: 0x00346846 File Offset: 0x00344A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownPush(RoleGoDownPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016862 RID: 92258 RVA: 0x0034685F File Offset: 0x00344A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownPush Clone()
		{
			return new RoleGoDownPush(this);
		}

		// Token: 0x06016863 RID: 92259 RVA: 0x00346867 File Offset: 0x00344A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGoDownPush);
		}

		// Token: 0x06016864 RID: 92260 RVA: 0x00346875 File Offset: 0x00344A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGoDownPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016865 RID: 92261 RVA: 0x00346894 File Offset: 0x00344A94
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

		// Token: 0x06016866 RID: 92262 RVA: 0x003468BA File Offset: 0x00344ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016867 RID: 92263 RVA: 0x003468C7 File Offset: 0x00344AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016868 RID: 92264 RVA: 0x003468D0 File Offset: 0x00344AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016869 RID: 92265 RVA: 0x003468E8 File Offset: 0x00344AE8
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

		// Token: 0x0601686A RID: 92266 RVA: 0x0034690E File Offset: 0x00344B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGoDownPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601686B RID: 92267 RVA: 0x0034692B File Offset: 0x00344B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601686C RID: 92268 RVA: 0x00346934 File Offset: 0x00344B34
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

		// Token: 0x0400870C RID: 34572
		private UnknownFieldSet _unknownFields;
	}
}
