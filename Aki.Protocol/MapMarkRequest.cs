using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097B RID: 2427
	[NetMessage(EMessageId.MapMarkRequest)]
	public sealed class MapMarkRequest : IMessage<MapMarkRequest>, IMessage, IEquatable<MapMarkRequest>, IDeepCloneable<MapMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D5B8 RID: 54712 RVA: 0x001F7529 File Offset: 0x001F5729
		[NullableContext(1)]
		public static MapMarkRequest Create()
		{
			return new MapMarkRequest();
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600D5B9 RID: 54713 RVA: 0x001F7530 File Offset: 0x001F5730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600D5BA RID: 54714 RVA: 0x001F7533 File Offset: 0x001F5733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x001F753A File Offset: 0x001F573A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest()
		{
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x001F7544 File Offset: 0x001F5744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest(MapMarkRequest other) : this()
		{
			this.markPointRequestInfo_ = ((other.markPointRequestInfo_ != null) ? other.markPointRequestInfo_.Clone() : null);
			MapMarkRequest.ParamsOneofCase paramsCase = other.ParamsCase;
			if (paramsCase != MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
			{
				if (paramsCase == MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
				{
					this.TreasureBoxParam = other.TreasureBoxParam.Clone();
				}
			}
			else
			{
				this.TemporaryTeleportParam = other.TemporaryTeleportParam.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x001F75B9 File Offset: 0x001F57B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest Clone()
		{
			return new MapMarkRequest(this);
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0600D5BE RID: 54718 RVA: 0x001F75C1 File Offset: 0x001F57C1
		// (set) Token: 0x0600D5BF RID: 54719 RVA: 0x001F75C9 File Offset: 0x001F57C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointRequestInfo MarkPointRequestInfo
		{
			get
			{
				return this.markPointRequestInfo_;
			}
			set
			{
				this.markPointRequestInfo_ = value;
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x0600D5C0 RID: 54720 RVA: 0x001F75D2 File Offset: 0x001F57D2
		// (set) Token: 0x0600D5C1 RID: 54721 RVA: 0x001F75EA File Offset: 0x001F57EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportParam TemporaryTeleportParam
		{
			get
			{
				if (this.paramsCase_ != MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
				{
					return null;
				}
				return (TemporaryTeleportParam)this.params_;
			}
			set
			{
				this.params_ = value;
				this.paramsCase_ = ((value == null) ? MapMarkRequest.ParamsOneofCase.None : MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam);
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x0600D5C2 RID: 54722 RVA: 0x001F7600 File Offset: 0x001F5800
		// (set) Token: 0x0600D5C3 RID: 54723 RVA: 0x001F7618 File Offset: 0x001F5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxParam TreasureBoxParam
		{
			get
			{
				if (this.paramsCase_ != MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
				{
					return null;
				}
				return (TreasureBoxParam)this.params_;
			}
			set
			{
				this.params_ = value;
				this.paramsCase_ = ((value == null) ? MapMarkRequest.ParamsOneofCase.None : MapMarkRequest.ParamsOneofCase.TreasureBoxParam);
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x0600D5C4 RID: 54724 RVA: 0x001F762E File Offset: 0x001F582E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest.ParamsOneofCase ParamsCase
		{
			get
			{
				return this.paramsCase_;
			}
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x001F7636 File Offset: 0x001F5836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearParams()
		{
			this.paramsCase_ = MapMarkRequest.ParamsOneofCase.None;
			this.params_ = null;
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x001F7646 File Offset: 0x001F5846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkRequest);
		}

		// Token: 0x0600D5C7 RID: 54727 RVA: 0x001F7654 File Offset: 0x001F5854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MarkPointRequestInfo, other.MarkPointRequestInfo) && object.Equals(this.TemporaryTeleportParam, other.TemporaryTeleportParam) && object.Equals(this.TreasureBoxParam, other.TreasureBoxParam) && this.ParamsCase == other.ParamsCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5C8 RID: 54728 RVA: 0x001F76CC File Offset: 0x001F58CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.markPointRequestInfo_ != null)
			{
				num ^= this.MarkPointRequestInfo.GetHashCode();
			}
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
			{
				num ^= this.TemporaryTeleportParam.GetHashCode();
			}
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
			{
				num ^= this.TreasureBoxParam.GetHashCode();
			}
			num ^= (int)this.paramsCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5C9 RID: 54729 RVA: 0x001F773F File Offset: 0x001F593F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5CA RID: 54730 RVA: 0x001F774C File Offset: 0x001F594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5CB RID: 54731 RVA: 0x001F7758 File Offset: 0x001F5958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TemporaryTeleportParam);
			}
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TreasureBoxParam);
			}
			if (this.markPointRequestInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MarkPointRequestInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5CC RID: 54732 RVA: 0x001F77D0 File Offset: 0x001F59D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.markPointRequestInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MarkPointRequestInfo);
			}
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TemporaryTeleportParam);
			}
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TreasureBoxParam);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x001F7840 File Offset: 0x001F5A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.markPointRequestInfo_ != null)
			{
				if (this.markPointRequestInfo_ == null)
				{
					this.MarkPointRequestInfo = new MarkPointRequestInfo();
				}
				this.MarkPointRequestInfo.MergeFrom(other.MarkPointRequestInfo);
			}
			MapMarkRequest.ParamsOneofCase paramsCase = other.ParamsCase;
			if (paramsCase != MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
			{
				if (paramsCase == MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
				{
					if (this.TreasureBoxParam == null)
					{
						this.TreasureBoxParam = new TreasureBoxParam();
					}
					this.TreasureBoxParam.MergeFrom(other.TreasureBoxParam);
				}
			}
			else
			{
				if (this.TemporaryTeleportParam == null)
				{
					this.TemporaryTeleportParam = new TemporaryTeleportParam();
				}
				this.TemporaryTeleportParam.MergeFrom(other.TemporaryTeleportParam);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5CE RID: 54734 RVA: 0x001F78EF File Offset: 0x001F5AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5CF RID: 54735 RVA: 0x001F78F8 File Offset: 0x001F5AF8
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
				if (num != 26U)
				{
					if (num != 34U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.markPointRequestInfo_ == null)
							{
								this.MarkPointRequestInfo = new MarkPointRequestInfo();
							}
							input.ReadMessage(this.MarkPointRequestInfo);
						}
					}
					else
					{
						TreasureBoxParam treasureBoxParam = new TreasureBoxParam();
						if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
						{
							treasureBoxParam.MergeFrom(this.TreasureBoxParam);
						}
						input.ReadMessage(treasureBoxParam);
						this.TreasureBoxParam = treasureBoxParam;
					}
				}
				else
				{
					TemporaryTeleportParam temporaryTeleportParam = new TemporaryTeleportParam();
					if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
					{
						temporaryTeleportParam.MergeFrom(this.TemporaryTeleportParam);
					}
					input.ReadMessage(temporaryTeleportParam);
					this.TemporaryTeleportParam = temporaryTeleportParam;
				}
			}
		}

		// Token: 0x040059CA RID: 22986
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059CB RID: 22987
		public const int MarkPointRequestInfoFieldNumber = 12;

		// Token: 0x040059CC RID: 22988
		private MarkPointRequestInfo markPointRequestInfo_;

		// Token: 0x040059CD RID: 22989
		public const int TemporaryTeleportParamFieldNumber = 3;

		// Token: 0x040059CE RID: 22990
		public const int TreasureBoxParamFieldNumber = 4;

		// Token: 0x040059CF RID: 22991
		private object params_;

		// Token: 0x040059D0 RID: 22992
		private MapMarkRequest.ParamsOneofCase paramsCase_;

		// Token: 0x020018A1 RID: 6305
		public enum ParamsOneofCase
		{
			// Token: 0x0400CD19 RID: 52505
			None,
			// Token: 0x0400CD1A RID: 52506
			TemporaryTeleportParam = 3,
			// Token: 0x0400CD1B RID: 52507
			TreasureBoxParam
		}
	}
}
