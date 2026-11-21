using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AE RID: 5294
	[NetMessage(EMessageId.TrapDefenseRefreshGainingGroupRequest)]
	public sealed class TrapDefenseRefreshGainingGroupRequest : IMessage<TrapDefenseRefreshGainingGroupRequest>, IMessage, IEquatable<TrapDefenseRefreshGainingGroupRequest>, IDeepCloneable<TrapDefenseRefreshGainingGroupRequest>, IBufferMessage
	{
		// Token: 0x0601C179 RID: 115065 RVA: 0x00413E82 File Offset: 0x00412082
		[NullableContext(1)]
		public static TrapDefenseRefreshGainingGroupRequest Create()
		{
			return new TrapDefenseRefreshGainingGroupRequest();
		}

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x0601C17A RID: 115066 RVA: 0x00413E89 File Offset: 0x00412089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x0601C17B RID: 115067 RVA: 0x00413E8C File Offset: 0x0041208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshGainingGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601C17C RID: 115068 RVA: 0x00413E93 File Offset: 0x00412093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupRequest()
		{
		}

		// Token: 0x0601C17D RID: 115069 RVA: 0x00413E9B File Offset: 0x0041209B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupRequest(TrapDefenseRefreshGainingGroupRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C17E RID: 115070 RVA: 0x00413EB4 File Offset: 0x004120B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupRequest Clone()
		{
			return new TrapDefenseRefreshGainingGroupRequest(this);
		}

		// Token: 0x0601C17F RID: 115071 RVA: 0x00413EBC File Offset: 0x004120BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshGainingGroupRequest);
		}

		// Token: 0x0601C180 RID: 115072 RVA: 0x00413ECA File Offset: 0x004120CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshGainingGroupRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C181 RID: 115073 RVA: 0x00413EE8 File Offset: 0x004120E8
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

		// Token: 0x0601C182 RID: 115074 RVA: 0x00413F0E File Offset: 0x0041210E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C183 RID: 115075 RVA: 0x00413F1B File Offset: 0x0041211B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C184 RID: 115076 RVA: 0x00413F24 File Offset: 0x00412124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C185 RID: 115077 RVA: 0x00413F3C File Offset: 0x0041213C
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

		// Token: 0x0601C186 RID: 115078 RVA: 0x00413F62 File Offset: 0x00412162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRefreshGainingGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C187 RID: 115079 RVA: 0x00413F7F File Offset: 0x0041217F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C188 RID: 115080 RVA: 0x00413F88 File Offset: 0x00412188
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

		// Token: 0x0400A291 RID: 41617
		private UnknownFieldSet _unknownFields;
	}
}
