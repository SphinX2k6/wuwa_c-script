using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001438 RID: 5176
	[NetMessage(EMessageId.TrapDefenseQuickEquipRequest)]
	public sealed class TrapDefenseQuickEquipRequest : IMessage<TrapDefenseQuickEquipRequest>, IMessage, IEquatable<TrapDefenseQuickEquipRequest>, IDeepCloneable<TrapDefenseQuickEquipRequest>, IBufferMessage
	{
		// Token: 0x0601B6BC RID: 112316 RVA: 0x003F8757 File Offset: 0x003F6957
		[NullableContext(1)]
		public static TrapDefenseQuickEquipRequest Create()
		{
			return new TrapDefenseQuickEquipRequest();
		}

		// Token: 0x17005C77 RID: 23671
		// (get) Token: 0x0601B6BD RID: 112317 RVA: 0x003F875E File Offset: 0x003F695E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C78 RID: 23672
		// (get) Token: 0x0601B6BE RID: 112318 RVA: 0x003F8761 File Offset: 0x003F6961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseQuickEquipRequest.Descriptor;
			}
		}

		// Token: 0x0601B6BF RID: 112319 RVA: 0x003F8768 File Offset: 0x003F6968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipRequest()
		{
		}

		// Token: 0x0601B6C0 RID: 112320 RVA: 0x003F8770 File Offset: 0x003F6970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipRequest(TrapDefenseQuickEquipRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6C1 RID: 112321 RVA: 0x003F8789 File Offset: 0x003F6989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipRequest Clone()
		{
			return new TrapDefenseQuickEquipRequest(this);
		}

		// Token: 0x0601B6C2 RID: 112322 RVA: 0x003F8791 File Offset: 0x003F6991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseQuickEquipRequest);
		}

		// Token: 0x0601B6C3 RID: 112323 RVA: 0x003F879F File Offset: 0x003F699F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseQuickEquipRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B6C4 RID: 112324 RVA: 0x003F87C0 File Offset: 0x003F69C0
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

		// Token: 0x0601B6C5 RID: 112325 RVA: 0x003F87E6 File Offset: 0x003F69E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6C6 RID: 112326 RVA: 0x003F87F3 File Offset: 0x003F69F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6C7 RID: 112327 RVA: 0x003F87FC File Offset: 0x003F69FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6C8 RID: 112328 RVA: 0x003F8814 File Offset: 0x003F6A14
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

		// Token: 0x0601B6C9 RID: 112329 RVA: 0x003F883A File Offset: 0x003F6A3A
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

		// Token: 0x0601B6CA RID: 112330 RVA: 0x003F8857 File Offset: 0x003F6A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6CB RID: 112331 RVA: 0x003F8860 File Offset: 0x003F6A60
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

		// Token: 0x04009E45 RID: 40517
		private UnknownFieldSet _unknownFields;
	}
}
