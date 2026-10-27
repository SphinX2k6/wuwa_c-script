using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001439 RID: 5177
	[NetMessage(EMessageId.TrapDefenseQuickEquipResponse)]
	public sealed class TrapDefenseQuickEquipResponse : IMessage<TrapDefenseQuickEquipResponse>, IMessage, IEquatable<TrapDefenseQuickEquipResponse>, IDeepCloneable<TrapDefenseQuickEquipResponse>, IBufferMessage
	{
		// Token: 0x0601B6CC RID: 112332 RVA: 0x003F8892 File Offset: 0x003F6A92
		[NullableContext(1)]
		public static TrapDefenseQuickEquipResponse Create()
		{
			return new TrapDefenseQuickEquipResponse();
		}

		// Token: 0x17005C79 RID: 23673
		// (get) Token: 0x0601B6CD RID: 112333 RVA: 0x003F8899 File Offset: 0x003F6A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C7A RID: 23674
		// (get) Token: 0x0601B6CE RID: 112334 RVA: 0x003F889C File Offset: 0x003F6A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseQuickEquipResponse.Descriptor;
			}
		}

		// Token: 0x0601B6CF RID: 112335 RVA: 0x003F88A3 File Offset: 0x003F6AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipResponse()
		{
		}

		// Token: 0x0601B6D0 RID: 112336 RVA: 0x003F88AB File Offset: 0x003F6AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipResponse(TrapDefenseQuickEquipResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6D1 RID: 112337 RVA: 0x003F88D0 File Offset: 0x003F6AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipResponse Clone()
		{
			return new TrapDefenseQuickEquipResponse(this);
		}

		// Token: 0x17005C7B RID: 23675
		// (get) Token: 0x0601B6D2 RID: 112338 RVA: 0x003F88D8 File Offset: 0x003F6AD8
		// (set) Token: 0x0601B6D3 RID: 112339 RVA: 0x003F88E0 File Offset: 0x003F6AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601B6D4 RID: 112340 RVA: 0x003F88E9 File Offset: 0x003F6AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseQuickEquipResponse);
		}

		// Token: 0x0601B6D5 RID: 112341 RVA: 0x003F88F7 File Offset: 0x003F6AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseQuickEquipResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B6D6 RID: 112342 RVA: 0x003F8928 File Offset: 0x003F6B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B6D7 RID: 112343 RVA: 0x003F896D File Offset: 0x003F6B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6D8 RID: 112344 RVA: 0x003F897A File Offset: 0x003F6B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6D9 RID: 112345 RVA: 0x003F8983 File Offset: 0x003F6B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6DA RID: 112346 RVA: 0x003F89B8 File Offset: 0x003F6BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B6DB RID: 112347 RVA: 0x003F89F6 File Offset: 0x003F6BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseQuickEquipResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B6DC RID: 112348 RVA: 0x003F8A27 File Offset: 0x003F6C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6DD RID: 112349 RVA: 0x003F8A30 File Offset: 0x003F6C30
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E46 RID: 40518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E47 RID: 40519
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009E48 RID: 40520
		private ErrorCode errorCode_;
	}
}
