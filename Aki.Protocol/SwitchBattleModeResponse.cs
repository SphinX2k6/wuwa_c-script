using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001367 RID: 4967
	[NetMessage(EMessageId.SwitchBattleModeResponse)]
	public sealed class SwitchBattleModeResponse : IMessage<SwitchBattleModeResponse>, IMessage, IEquatable<SwitchBattleModeResponse>, IDeepCloneable<SwitchBattleModeResponse>, IBufferMessage
	{
		// Token: 0x0601A744 RID: 108356 RVA: 0x003DACA4 File Offset: 0x003D8EA4
		[NullableContext(1)]
		public static SwitchBattleModeResponse Create()
		{
			return new SwitchBattleModeResponse();
		}

		// Token: 0x17005990 RID: 22928
		// (get) Token: 0x0601A745 RID: 108357 RVA: 0x003DACAB File Offset: 0x003D8EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005991 RID: 22929
		// (get) Token: 0x0601A746 RID: 108358 RVA: 0x003DACAE File Offset: 0x003D8EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchBattleModeResponse.Descriptor;
			}
		}

		// Token: 0x0601A747 RID: 108359 RVA: 0x003DACB5 File Offset: 0x003D8EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeResponse()
		{
		}

		// Token: 0x0601A748 RID: 108360 RVA: 0x003DACBD File Offset: 0x003D8EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeResponse(SwitchBattleModeResponse other) : this()
		{
			this.client_ = other.client_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A749 RID: 108361 RVA: 0x003DACE2 File Offset: 0x003D8EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeResponse Clone()
		{
			return new SwitchBattleModeResponse(this);
		}

		// Token: 0x17005992 RID: 22930
		// (get) Token: 0x0601A74A RID: 108362 RVA: 0x003DACEA File Offset: 0x003D8EEA
		// (set) Token: 0x0601A74B RID: 108363 RVA: 0x003DACF2 File Offset: 0x003D8EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Client
		{
			get
			{
				return this.client_;
			}
			set
			{
				this.client_ = value;
			}
		}

		// Token: 0x0601A74C RID: 108364 RVA: 0x003DACFB File Offset: 0x003D8EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchBattleModeResponse);
		}

		// Token: 0x0601A74D RID: 108365 RVA: 0x003DAD09 File Offset: 0x003D8F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchBattleModeResponse other)
		{
			return other != null && (other == this || (this.Client == other.Client && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A74E RID: 108366 RVA: 0x003DAD38 File Offset: 0x003D8F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Client)
			{
				num ^= this.Client.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A74F RID: 108367 RVA: 0x003DAD77 File Offset: 0x003D8F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A750 RID: 108368 RVA: 0x003DAD84 File Offset: 0x003D8F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A751 RID: 108369 RVA: 0x003DAD8D File Offset: 0x003D8F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Client)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Client);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A752 RID: 108370 RVA: 0x003DADC0 File Offset: 0x003D8FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Client)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A753 RID: 108371 RVA: 0x003DADF2 File Offset: 0x003D8FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchBattleModeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Client)
			{
				this.Client = other.Client;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A754 RID: 108372 RVA: 0x003DAE23 File Offset: 0x003D9023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A755 RID: 108373 RVA: 0x003DAE2C File Offset: 0x003D902C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Client = input.ReadBool();
				}
			}
		}

		// Token: 0x04009B33 RID: 39731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B34 RID: 39732
		public const int ClientFieldNumber = 9;

		// Token: 0x04009B35 RID: 39733
		private bool client_;
	}
}
