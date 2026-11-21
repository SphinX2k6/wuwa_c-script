using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F9 RID: 4345
	[NetMessage(EMessageId.RoleTowerTimerDataUpdateNotify)]
	public sealed class RoleTowerTimerDataUpdateNotify : IMessage<RoleTowerTimerDataUpdateNotify>, IMessage, IEquatable<RoleTowerTimerDataUpdateNotify>, IDeepCloneable<RoleTowerTimerDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x060173AE RID: 95150 RVA: 0x003619C2 File Offset: 0x0035FBC2
		[NullableContext(1)]
		public static RoleTowerTimerDataUpdateNotify Create()
		{
			return new RoleTowerTimerDataUpdateNotify();
		}

		// Token: 0x17004E0C RID: 19980
		// (get) Token: 0x060173AF RID: 95151 RVA: 0x003619C9 File Offset: 0x0035FBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E0D RID: 19981
		// (get) Token: 0x060173B0 RID: 95152 RVA: 0x003619CC File Offset: 0x0035FBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTimerDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060173B1 RID: 95153 RVA: 0x003619D3 File Offset: 0x0035FBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerDataUpdateNotify()
		{
		}

		// Token: 0x060173B2 RID: 95154 RVA: 0x003619DB File Offset: 0x0035FBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerDataUpdateNotify(RoleTowerTimerDataUpdateNotify other) : this()
		{
			this.timeData_ = ((other.timeData_ != null) ? other.timeData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173B3 RID: 95155 RVA: 0x00361A10 File Offset: 0x0035FC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerDataUpdateNotify Clone()
		{
			return new RoleTowerTimerDataUpdateNotify(this);
		}

		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x060173B4 RID: 95156 RVA: 0x00361A18 File Offset: 0x0035FC18
		// (set) Token: 0x060173B5 RID: 95157 RVA: 0x00361A20 File Offset: 0x0035FC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerData TimeData
		{
			get
			{
				return this.timeData_;
			}
			set
			{
				this.timeData_ = value;
			}
		}

		// Token: 0x060173B6 RID: 95158 RVA: 0x00361A29 File Offset: 0x0035FC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTimerDataUpdateNotify);
		}

		// Token: 0x060173B7 RID: 95159 RVA: 0x00361A37 File Offset: 0x0035FC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTimerDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TimeData, other.TimeData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173B8 RID: 95160 RVA: 0x00361A6C File Offset: 0x0035FC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.timeData_ != null)
			{
				num ^= this.TimeData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060173B9 RID: 95161 RVA: 0x00361AA8 File Offset: 0x0035FCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060173BA RID: 95162 RVA: 0x00361AB5 File Offset: 0x0035FCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060173BB RID: 95163 RVA: 0x00361ABE File Offset: 0x0035FCBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.timeData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TimeData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060173BC RID: 95164 RVA: 0x00361AF0 File Offset: 0x0035FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.timeData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TimeData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060173BD RID: 95165 RVA: 0x00361B30 File Offset: 0x0035FD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTimerDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.timeData_ != null)
			{
				if (this.timeData_ == null)
				{
					this.TimeData = new RoleTowerTimerData();
				}
				this.TimeData.MergeFrom(other.TimeData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060173BE RID: 95166 RVA: 0x00361B84 File Offset: 0x0035FD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060173BF RID: 95167 RVA: 0x00361B90 File Offset: 0x0035FD90
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
					if (this.timeData_ == null)
					{
						this.TimeData = new RoleTowerTimerData();
					}
					input.ReadMessage(this.TimeData);
				}
			}
		}

		// Token: 0x04008AF4 RID: 35572
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AF5 RID: 35573
		public const int TimeDataFieldNumber = 1;

		// Token: 0x04008AF6 RID: 35574
		private RoleTowerTimerData timeData_;
	}
}
