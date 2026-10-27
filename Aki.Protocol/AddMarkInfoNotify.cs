using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A7 RID: 167
	[NetMessage(EMessageId.AddMarkInfoNotify)]
	public sealed class AddMarkInfoNotify : IMessage<AddMarkInfoNotify>, IMessage, IEquatable<AddMarkInfoNotify>, IDeepCloneable<AddMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x06001CCB RID: 7371 RVA: 0x0004F8FB File Offset: 0x0004DAFB
		[NullableContext(1)]
		public static AddMarkInfoNotify Create()
		{
			return new AddMarkInfoNotify();
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0004F902 File Offset: 0x0004DB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x0004F905 File Offset: 0x0004DB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0004F90C File Offset: 0x0004DB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddMarkInfoNotify()
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0004F914 File Offset: 0x0004DB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddMarkInfoNotify(AddMarkInfoNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.treasureBoxMarkInfo_ = ((other.treasureBoxMarkInfo_ != null) ? other.treasureBoxMarkInfo_.Clone() : null);
			this.attachMark_ = ((other.attachMark_ != null) ? other.attachMark_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0004F98C File Offset: 0x0004DB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddMarkInfoNotify Clone()
		{
			return new AddMarkInfoNotify(this);
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x0004F994 File Offset: 0x0004DB94
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x0004F99C File Offset: 0x0004DB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0004F9A5 File Offset: 0x0004DBA5
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0004F9AD File Offset: 0x0004DBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo TreasureBoxMarkInfo
		{
			get
			{
				return this.treasureBoxMarkInfo_;
			}
			set
			{
				this.treasureBoxMarkInfo_ = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0004F9B6 File Offset: 0x0004DBB6
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0004F9BE File Offset: 0x0004DBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo AttachMark
		{
			get
			{
				return this.attachMark_;
			}
			set
			{
				this.attachMark_ = value;
			}
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0004F9C7 File Offset: 0x0004DBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddMarkInfoNotify);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0004F9D8 File Offset: 0x0004DBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddMarkInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this.TreasureBoxMarkInfo, other.TreasureBoxMarkInfo) && object.Equals(this.AttachMark, other.AttachMark) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0004FA40 File Offset: 0x0004DC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.treasureBoxMarkInfo_ != null)
			{
				num ^= this.TreasureBoxMarkInfo.GetHashCode();
			}
			if (this.attachMark_ != null)
			{
				num ^= this.AttachMark.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0004FAB5 File Offset: 0x0004DCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0004FAC0 File Offset: 0x0004DCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.treasureBoxMarkInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TreasureBoxMarkInfo);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Info);
			}
			if (this.attachMark_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AttachMark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0004FB38 File Offset: 0x0004DD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.treasureBoxMarkInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TreasureBoxMarkInfo);
			}
			if (this.attachMark_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttachMark);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0004FBA8 File Offset: 0x0004DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddMarkInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new MarkPointInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.treasureBoxMarkInfo_ != null)
			{
				if (this.treasureBoxMarkInfo_ == null)
				{
					this.TreasureBoxMarkInfo = new MarkTreasureBoxInfo();
				}
				this.TreasureBoxMarkInfo.MergeFrom(other.TreasureBoxMarkInfo);
			}
			if (other.attachMark_ != null)
			{
				if (this.attachMark_ == null)
				{
					this.AttachMark = new AttachMarkInfo();
				}
				this.AttachMark.MergeFrom(other.AttachMark);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0004FC54 File Offset: 0x0004DE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0004FC60 File Offset: 0x0004DE60
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
					if (num != 66U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.attachMark_ == null)
							{
								this.AttachMark = new AttachMarkInfo();
							}
							input.ReadMessage(this.AttachMark);
						}
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new MarkPointInfo();
						}
						input.ReadMessage(this.Info);
					}
				}
				else
				{
					if (this.treasureBoxMarkInfo_ == null)
					{
						this.TreasureBoxMarkInfo = new MarkTreasureBoxInfo();
					}
					input.ReadMessage(this.TreasureBoxMarkInfo);
				}
			}
		}

		// Token: 0x040022F3 RID: 8947
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022F4 RID: 8948
		public const int InfoFieldNumber = 8;

		// Token: 0x040022F5 RID: 8949
		private MarkPointInfo info_;

		// Token: 0x040022F6 RID: 8950
		public const int TreasureBoxMarkInfoFieldNumber = 7;

		// Token: 0x040022F7 RID: 8951
		private MarkTreasureBoxInfo treasureBoxMarkInfo_;

		// Token: 0x040022F8 RID: 8952
		public const int AttachMarkFieldNumber = 14;

		// Token: 0x040022F9 RID: 8953
		private AttachMarkInfo attachMark_;
	}
}
