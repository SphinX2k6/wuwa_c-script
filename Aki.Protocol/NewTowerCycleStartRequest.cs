using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B22 RID: 2850
	[NetMessage(EMessageId.NewTowerCycleStartRequest)]
	public sealed class NewTowerCycleStartRequest : IMessage<NewTowerCycleStartRequest>, IMessage, IEquatable<NewTowerCycleStartRequest>, IDeepCloneable<NewTowerCycleStartRequest>, IBufferMessage
	{
		// Token: 0x0600F7C7 RID: 63431 RVA: 0x00242CB9 File Offset: 0x00240EB9
		[NullableContext(1)]
		public static NewTowerCycleStartRequest Create()
		{
			return new NewTowerCycleStartRequest();
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600F7C8 RID: 63432 RVA: 0x00242CC0 File Offset: 0x00240EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600F7C9 RID: 63433 RVA: 0x00242CC3 File Offset: 0x00240EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleStartRequest.Descriptor;
			}
		}

		// Token: 0x0600F7CA RID: 63434 RVA: 0x00242CCA File Offset: 0x00240ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartRequest()
		{
		}

		// Token: 0x0600F7CB RID: 63435 RVA: 0x00242CD2 File Offset: 0x00240ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartRequest(NewTowerCycleStartRequest other) : this()
		{
			this.param_ = ((other.param_ != null) ? other.param_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F7CC RID: 63436 RVA: 0x00242D07 File Offset: 0x00240F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartRequest Clone()
		{
			return new NewTowerCycleStartRequest(this);
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600F7CD RID: 63437 RVA: 0x00242D0F File Offset: 0x00240F0F
		// (set) Token: 0x0600F7CE RID: 63438 RVA: 0x00242D17 File Offset: 0x00240F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartParam Param
		{
			get
			{
				return this.param_;
			}
			set
			{
				this.param_ = value;
			}
		}

		// Token: 0x0600F7CF RID: 63439 RVA: 0x00242D20 File Offset: 0x00240F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleStartRequest);
		}

		// Token: 0x0600F7D0 RID: 63440 RVA: 0x00242D2E File Offset: 0x00240F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleStartRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Param, other.Param) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7D1 RID: 63441 RVA: 0x00242D64 File Offset: 0x00240F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.param_ != null)
			{
				num ^= this.Param.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F7D2 RID: 63442 RVA: 0x00242DA0 File Offset: 0x00240FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7D3 RID: 63443 RVA: 0x00242DAD File Offset: 0x00240FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7D4 RID: 63444 RVA: 0x00242DB6 File Offset: 0x00240FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.param_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Param);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x00242DE8 File Offset: 0x00240FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.param_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Param);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x00242E28 File Offset: 0x00241028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerCycleStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.param_ != null)
			{
				if (this.param_ == null)
				{
					this.Param = new NewTowerCycleStartParam();
				}
				this.Param.MergeFrom(other.Param);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x00242E7C File Offset: 0x0024107C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x00242E88 File Offset: 0x00241088
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.param_ == null)
					{
						this.Param = new NewTowerCycleStartParam();
					}
					input.ReadMessage(this.Param);
				}
			}
		}

		// Token: 0x040063D9 RID: 25561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063DA RID: 25562
		public const int ParamFieldNumber = 7;

		// Token: 0x040063DB RID: 25563
		private NewTowerCycleStartParam param_;
	}
}
