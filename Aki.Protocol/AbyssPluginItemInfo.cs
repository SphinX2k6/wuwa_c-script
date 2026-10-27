using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000032 RID: 50
	public sealed class AbyssPluginItemInfo : IMessage<AbyssPluginItemInfo>, IMessage, IEquatable<AbyssPluginItemInfo>, IDeepCloneable<AbyssPluginItemInfo>, IBufferMessage
	{
		// Token: 0x0600127B RID: 4731 RVA: 0x00032D41 File Offset: 0x00030F41
		[NullableContext(1)]
		public static AbyssPluginItemInfo Create()
		{
			return new AbyssPluginItemInfo();
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00032D48 File Offset: 0x00030F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssPluginItemInfo> Parser
		{
			get
			{
				return AbyssPluginItemInfo._parser;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00032D4F File Offset: 0x00030F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00032D52 File Offset: 0x00030F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemInfo.Descriptor;
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00032D59 File Offset: 0x00030F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfo()
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00032D64 File Offset: 0x00030F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfo(AbyssPluginItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this.funcValue_ = other.funcValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00032DB8 File Offset: 0x00030FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfo Clone()
		{
			return new AbyssPluginItemInfo(this);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x00032DC0 File Offset: 0x00030FC0
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x00032DC8 File Offset: 0x00030FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00032DD1 File Offset: 0x00030FD1
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00032DD9 File Offset: 0x00030FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x00032DE2 File Offset: 0x00030FE2
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x00032DEA File Offset: 0x00030FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00032DF3 File Offset: 0x00030FF3
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x00032DFB File Offset: 0x00030FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncValue
		{
			get
			{
				return this.funcValue_;
			}
			set
			{
				this.funcValue_ = value;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00032E04 File Offset: 0x00031004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemInfo);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00032E14 File Offset: 0x00031014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00032E80 File Offset: 0x00031080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.FuncValue != 0)
			{
				num ^= this.FuncValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00032F0A File Offset: 0x0003110A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00032F17 File Offset: 0x00031117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00032F20 File Offset: 0x00031120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FuncValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00032FB0 File Offset: 0x000311B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00033038 File Offset: 0x00031238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.FuncValue != 0)
			{
				this.FuncValue = other.FuncValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000330B0 File Offset: 0x000312B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x000330BC File Offset: 0x000312BC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IncrId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FuncValue = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FCE RID: 8142
		private static readonly MessageParser<AbyssPluginItemInfo> _parser = new MessageParser<AbyssPluginItemInfo>(() => new AbyssPluginItemInfo());

		// Token: 0x04001FCF RID: 8143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FD0 RID: 8144
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04001FD1 RID: 8145
		private int itemId_;

		// Token: 0x04001FD2 RID: 8146
		public const int CountFieldNumber = 2;

		// Token: 0x04001FD3 RID: 8147
		private int count_;

		// Token: 0x04001FD4 RID: 8148
		public const int IncrIdFieldNumber = 3;

		// Token: 0x04001FD5 RID: 8149
		private int incrId_;

		// Token: 0x04001FD6 RID: 8150
		public const int FuncValueFieldNumber = 4;

		// Token: 0x04001FD7 RID: 8151
		private int funcValue_;
	}
}
