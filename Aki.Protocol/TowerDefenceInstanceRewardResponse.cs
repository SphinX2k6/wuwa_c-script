using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A3 RID: 5027
	[NetMessage(EMessageId.TowerDefenceInstanceRewardResponse)]
	public sealed class TowerDefenceInstanceRewardResponse : IMessage<TowerDefenceInstanceRewardResponse>, IMessage, IEquatable<TowerDefenceInstanceRewardResponse>, IDeepCloneable<TowerDefenceInstanceRewardResponse>, IBufferMessage
	{
		// Token: 0x0601AAC6 RID: 109254 RVA: 0x003DE695 File Offset: 0x003DC895
		[NullableContext(1)]
		public static TowerDefenceInstanceRewardResponse Create()
		{
			return new TowerDefenceInstanceRewardResponse();
		}

		// Token: 0x170059F1 RID: 23025
		// (get) Token: 0x0601AAC7 RID: 109255 RVA: 0x003DE69C File Offset: 0x003DC89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059F2 RID: 23026
		// (get) Token: 0x0601AAC8 RID: 109256 RVA: 0x003DE69F File Offset: 0x003DC89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601AAC9 RID: 109257 RVA: 0x003DE6A6 File Offset: 0x003DC8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardResponse()
		{
		}

		// Token: 0x0601AACA RID: 109258 RVA: 0x003DE6AE File Offset: 0x003DC8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardResponse(TowerDefenceInstanceRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AACB RID: 109259 RVA: 0x003DE6D3 File Offset: 0x003DC8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardResponse Clone()
		{
			return new TowerDefenceInstanceRewardResponse(this);
		}

		// Token: 0x170059F3 RID: 23027
		// (get) Token: 0x0601AACC RID: 109260 RVA: 0x003DE6DB File Offset: 0x003DC8DB
		// (set) Token: 0x0601AACD RID: 109261 RVA: 0x003DE6E3 File Offset: 0x003DC8E3
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

		// Token: 0x0601AACE RID: 109262 RVA: 0x003DE6EC File Offset: 0x003DC8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceRewardResponse);
		}

		// Token: 0x0601AACF RID: 109263 RVA: 0x003DE6FA File Offset: 0x003DC8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AAD0 RID: 109264 RVA: 0x003DE728 File Offset: 0x003DC928
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

		// Token: 0x0601AAD1 RID: 109265 RVA: 0x003DE76D File Offset: 0x003DC96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AAD2 RID: 109266 RVA: 0x003DE77A File Offset: 0x003DC97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAD3 RID: 109267 RVA: 0x003DE783 File Offset: 0x003DC983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAD4 RID: 109268 RVA: 0x003DE7B8 File Offset: 0x003DC9B8
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

		// Token: 0x0601AAD5 RID: 109269 RVA: 0x003DE7F6 File Offset: 0x003DC9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInstanceRewardResponse other)
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

		// Token: 0x0601AAD6 RID: 109270 RVA: 0x003DE827 File Offset: 0x003DCA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAD7 RID: 109271 RVA: 0x003DE830 File Offset: 0x003DCA30
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009AF2 RID: 39666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AF3 RID: 39667
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009AF4 RID: 39668
		private ErrorCode errorCode_;
	}
}
