using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140E RID: 5134
	[NetMessage(EMessageId.TowerDefenceChallengeQuitRequest)]
	public sealed class TowerDefenceChallengeQuitRequest : IMessage<TowerDefenceChallengeQuitRequest>, IMessage, IEquatable<TowerDefenceChallengeQuitRequest>, IDeepCloneable<TowerDefenceChallengeQuitRequest>, IBufferMessage
	{
		// Token: 0x0601B4A7 RID: 111783 RVA: 0x003F81E6 File Offset: 0x003F63E6
		[NullableContext(1)]
		public static TowerDefenceChallengeQuitRequest Create()
		{
			return new TowerDefenceChallengeQuitRequest();
		}

		// Token: 0x17005C61 RID: 23649
		// (get) Token: 0x0601B4A8 RID: 111784 RVA: 0x003F81ED File Offset: 0x003F63ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C62 RID: 23650
		// (get) Token: 0x0601B4A9 RID: 111785 RVA: 0x003F81F0 File Offset: 0x003F63F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceChallengeQuitRequest.Descriptor;
			}
		}

		// Token: 0x0601B4AA RID: 111786 RVA: 0x003F81F7 File Offset: 0x003F63F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitRequest()
		{
		}

		// Token: 0x0601B4AB RID: 111787 RVA: 0x003F81FF File Offset: 0x003F63FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitRequest(TowerDefenceChallengeQuitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4AC RID: 111788 RVA: 0x003F8218 File Offset: 0x003F6418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitRequest Clone()
		{
			return new TowerDefenceChallengeQuitRequest(this);
		}

		// Token: 0x0601B4AD RID: 111789 RVA: 0x003F8220 File Offset: 0x003F6420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceChallengeQuitRequest);
		}

		// Token: 0x0601B4AE RID: 111790 RVA: 0x003F822E File Offset: 0x003F642E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceChallengeQuitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B4AF RID: 111791 RVA: 0x003F824C File Offset: 0x003F644C
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

		// Token: 0x0601B4B0 RID: 111792 RVA: 0x003F8272 File Offset: 0x003F6472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4B1 RID: 111793 RVA: 0x003F827F File Offset: 0x003F647F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4B2 RID: 111794 RVA: 0x003F8288 File Offset: 0x003F6488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4B3 RID: 111795 RVA: 0x003F82A0 File Offset: 0x003F64A0
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

		// Token: 0x0601B4B4 RID: 111796 RVA: 0x003F82C6 File Offset: 0x003F64C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceChallengeQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B4B5 RID: 111797 RVA: 0x003F82E3 File Offset: 0x003F64E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4B6 RID: 111798 RVA: 0x003F82EC File Offset: 0x003F64EC
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

		// Token: 0x04009F04 RID: 40708
		private UnknownFieldSet _unknownFields;
	}
}
