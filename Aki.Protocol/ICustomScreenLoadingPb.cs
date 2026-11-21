using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AB RID: 1963
	public sealed class ICustomScreenLoadingPb : IMessage<ICustomScreenLoadingPb>, IMessage, IEquatable<ICustomScreenLoadingPb>, IDeepCloneable<ICustomScreenLoadingPb>, IBufferMessage
	{
		// Token: 0x0600B111 RID: 45329 RVA: 0x001A882A File Offset: 0x001A6A2A
		[NullableContext(1)]
		public static ICustomScreenLoadingPb Create()
		{
			return new ICustomScreenLoadingPb();
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x0600B112 RID: 45330 RVA: 0x001A8831 File Offset: 0x001A6A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x0600B113 RID: 45331 RVA: 0x001A8834 File Offset: 0x001A6A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenLoadingPb.Descriptor;
			}
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x001A883B File Offset: 0x001A6A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb()
		{
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x001A8843 File Offset: 0x001A6A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb(ICustomScreenLoadingPb other) : this()
		{
			if (other.LoadingTypeCase == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				this.ICustomScreenLoadingCyberpunkPb = other.ICustomScreenLoadingCyberpunkPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x001A8876 File Offset: 0x001A6A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb Clone()
		{
			return new ICustomScreenLoadingPb(this);
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x0600B117 RID: 45335 RVA: 0x001A887E File Offset: 0x001A6A7E
		// (set) Token: 0x0600B118 RID: 45336 RVA: 0x001A8896 File Offset: 0x001A6A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb ICustomScreenLoadingCyberpunkPb
		{
			get
			{
				if (this.loadingTypeCase_ != ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
				{
					return null;
				}
				return (ICustomScreenLoadingCyberpunkPb)this.loadingType_;
			}
			set
			{
				this.loadingType_ = value;
				this.loadingTypeCase_ = ((value == null) ? ICustomScreenLoadingPb.LoadingTypeOneofCase.None : ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb);
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x0600B119 RID: 45337 RVA: 0x001A88AC File Offset: 0x001A6AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb.LoadingTypeOneofCase LoadingTypeCase
		{
			get
			{
				return this.loadingTypeCase_;
			}
		}

		// Token: 0x0600B11A RID: 45338 RVA: 0x001A88B4 File Offset: 0x001A6AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLoadingType()
		{
			this.loadingTypeCase_ = ICustomScreenLoadingPb.LoadingTypeOneofCase.None;
			this.loadingType_ = null;
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x001A88C4 File Offset: 0x001A6AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenLoadingPb);
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x001A88D4 File Offset: 0x001A6AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenLoadingPb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenLoadingCyberpunkPb, other.ICustomScreenLoadingCyberpunkPb) && this.LoadingTypeCase == other.LoadingTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x001A8924 File Offset: 0x001A6B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				num ^= this.ICustomScreenLoadingCyberpunkPb.GetHashCode();
			}
			num ^= (int)this.loadingTypeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B11E RID: 45342 RVA: 0x001A896A File Offset: 0x001A6B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B11F RID: 45343 RVA: 0x001A8977 File Offset: 0x001A6B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x001A8980 File Offset: 0x001A6B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ICustomScreenLoadingCyberpunkPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x001A89B4 File Offset: 0x001A6BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenLoadingCyberpunkPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B122 RID: 45346 RVA: 0x001A89F4 File Offset: 0x001A6BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenLoadingPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadingTypeCase == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				if (this.ICustomScreenLoadingCyberpunkPb == null)
				{
					this.ICustomScreenLoadingCyberpunkPb = new ICustomScreenLoadingCyberpunkPb();
				}
				this.ICustomScreenLoadingCyberpunkPb.MergeFrom(other.ICustomScreenLoadingCyberpunkPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B123 RID: 45347 RVA: 0x001A8A49 File Offset: 0x001A6C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B124 RID: 45348 RVA: 0x001A8A54 File Offset: 0x001A6C54
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					ICustomScreenLoadingCyberpunkPb customScreenLoadingCyberpunkPb = new ICustomScreenLoadingCyberpunkPb();
					if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
					{
						customScreenLoadingCyberpunkPb.MergeFrom(this.ICustomScreenLoadingCyberpunkPb);
					}
					input.ReadMessage(customScreenLoadingCyberpunkPb);
					this.ICustomScreenLoadingCyberpunkPb = customScreenLoadingCyberpunkPb;
				}
			}
		}

		// Token: 0x04004FB8 RID: 20408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FB9 RID: 20409
		public const int ICustomScreenLoadingCyberpunkPbFieldNumber = 1;

		// Token: 0x04004FBA RID: 20410
		private object loadingType_;

		// Token: 0x04004FBB RID: 20411
		private ICustomScreenLoadingPb.LoadingTypeOneofCase loadingTypeCase_;

		// Token: 0x0200186A RID: 6250
		public enum LoadingTypeOneofCase
		{
			// Token: 0x0400CCBF RID: 52415
			None,
			// Token: 0x0400CCC0 RID: 52416
			ICustomScreenLoadingCyberpunkPb
		}
	}
}
