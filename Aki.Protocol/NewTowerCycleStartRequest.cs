using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B33 RID: 2867
	[NetMessage(EMessageId.NewTowerCycleStartRequest)]
	public sealed class NewTowerCycleStartRequest : IMessage<NewTowerCycleStartRequest>, IMessage, IEquatable<NewTowerCycleStartRequest>, IDeepCloneable<NewTowerCycleStartRequest>, IBufferMessage
	{
		// Token: 0x0600F8E1 RID: 63713 RVA: 0x00244ED5 File Offset: 0x002430D5
		[NullableContext(1)]
		public static NewTowerCycleStartRequest Create()
		{
			return new NewTowerCycleStartRequest();
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600F8E2 RID: 63714 RVA: 0x00244EDC File Offset: 0x002430DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600F8E3 RID: 63715 RVA: 0x00244EDF File Offset: 0x002430DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleStartRequest.Descriptor;
			}
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x00244EE6 File Offset: 0x002430E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartRequest()
		{
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x00244EEE File Offset: 0x002430EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartRequest(NewTowerCycleStartRequest other) : this()
		{
			this.param_ = ((other.param_ != null) ? other.param_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x00244F23 File Offset: 0x00243123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartRequest Clone()
		{
			return new NewTowerCycleStartRequest(this);
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600F8E7 RID: 63719 RVA: 0x00244F2B File Offset: 0x0024312B
		// (set) Token: 0x0600F8E8 RID: 63720 RVA: 0x00244F33 File Offset: 0x00243133
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

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x00244F3C File Offset: 0x0024313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleStartRequest);
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x00244F4A File Offset: 0x0024314A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleStartRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Param, other.Param) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x00244F80 File Offset: 0x00243180
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

		// Token: 0x0600F8EC RID: 63724 RVA: 0x00244FBC File Offset: 0x002431BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8ED RID: 63725 RVA: 0x00244FC9 File Offset: 0x002431C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8EE RID: 63726 RVA: 0x00244FD2 File Offset: 0x002431D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.param_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Param);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F8EF RID: 63727 RVA: 0x00245004 File Offset: 0x00243204
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

		// Token: 0x0600F8F0 RID: 63728 RVA: 0x00245044 File Offset: 0x00243244
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

		// Token: 0x0600F8F1 RID: 63729 RVA: 0x00245098 File Offset: 0x00243298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8F2 RID: 63730 RVA: 0x002450A4 File Offset: 0x002432A4
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
				if (num != 82U)
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

		// Token: 0x040063D0 RID: 25552
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063D1 RID: 25553
		public const int ParamFieldNumber = 10;

		// Token: 0x040063D2 RID: 25554
		private NewTowerCycleStartParam param_;
	}
}
