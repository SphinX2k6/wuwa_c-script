using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AB RID: 5291
	[NetMessage(EMessageId.TrapDefenseQuickEquipRequest)]
	public sealed class TrapDefenseQuickEquipRequest : IMessage<TrapDefenseQuickEquipRequest>, IMessage, IEquatable<TrapDefenseQuickEquipRequest>, IDeepCloneable<TrapDefenseQuickEquipRequest>, IBufferMessage
	{
		// Token: 0x0601C147 RID: 115015 RVA: 0x00413A2B File Offset: 0x00411C2B
		[NullableContext(1)]
		public static TrapDefenseQuickEquipRequest Create()
		{
			return new TrapDefenseQuickEquipRequest();
		}

		// Token: 0x17005F0C RID: 24332
		// (get) Token: 0x0601C148 RID: 115016 RVA: 0x00413A32 File Offset: 0x00411C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F0D RID: 24333
		// (get) Token: 0x0601C149 RID: 115017 RVA: 0x00413A35 File Offset: 0x00411C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseQuickEquipRequest.Descriptor;
			}
		}

		// Token: 0x0601C14A RID: 115018 RVA: 0x00413A3C File Offset: 0x00411C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipRequest()
		{
		}

		// Token: 0x0601C14B RID: 115019 RVA: 0x00413A44 File Offset: 0x00411C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipRequest(TrapDefenseQuickEquipRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C14C RID: 115020 RVA: 0x00413A5D File Offset: 0x00411C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipRequest Clone()
		{
			return new TrapDefenseQuickEquipRequest(this);
		}

		// Token: 0x0601C14D RID: 115021 RVA: 0x00413A65 File Offset: 0x00411C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseQuickEquipRequest);
		}

		// Token: 0x0601C14E RID: 115022 RVA: 0x00413A73 File Offset: 0x00411C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseQuickEquipRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C14F RID: 115023 RVA: 0x00413A94 File Offset: 0x00411C94
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

		// Token: 0x0601C150 RID: 115024 RVA: 0x00413ABA File Offset: 0x00411CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C151 RID: 115025 RVA: 0x00413AC7 File Offset: 0x00411CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C152 RID: 115026 RVA: 0x00413AD0 File Offset: 0x00411CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C153 RID: 115027 RVA: 0x00413AE8 File Offset: 0x00411CE8
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

		// Token: 0x0601C154 RID: 115028 RVA: 0x00413B0E File Offset: 0x00411D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseQuickEquipRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C155 RID: 115029 RVA: 0x00413B2B File Offset: 0x00411D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C156 RID: 115030 RVA: 0x00413B34 File Offset: 0x00411D34
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

		// Token: 0x0400A28C RID: 41612
		private UnknownFieldSet _unknownFields;
	}
}
