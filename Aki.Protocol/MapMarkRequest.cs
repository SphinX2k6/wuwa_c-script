using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098C RID: 2444
	[NetMessage(EMessageId.MapMarkRequest)]
	public sealed class MapMarkRequest : IMessage<MapMarkRequest>, IMessage, IEquatable<MapMarkRequest>, IDeepCloneable<MapMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D6D2 RID: 54994 RVA: 0x001F970C File Offset: 0x001F790C
		[NullableContext(1)]
		public static MapMarkRequest Create()
		{
			return new MapMarkRequest();
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0600D6D3 RID: 54995 RVA: 0x001F9713 File Offset: 0x001F7913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x0600D6D4 RID: 54996 RVA: 0x001F9716 File Offset: 0x001F7916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x001F971D File Offset: 0x001F791D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest()
		{
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x001F9728 File Offset: 0x001F7928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest(MapMarkRequest other) : this()
		{
			this.markPointRequestInfo_ = ((other.markPointRequestInfo_ != null) ? other.markPointRequestInfo_.Clone() : null);
			MapMarkRequest.ParamsOneofCase paramsCase = other.ParamsCase;
			if (paramsCase != MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
			{
				if (paramsCase == MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
				{
					this.TemporaryTeleportParam = other.TemporaryTeleportParam.Clone();
				}
			}
			else
			{
				this.TreasureBoxParam = other.TreasureBoxParam.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x001F979C File Offset: 0x001F799C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest Clone()
		{
			return new MapMarkRequest(this);
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x0600D6D8 RID: 55000 RVA: 0x001F97A4 File Offset: 0x001F79A4
		// (set) Token: 0x0600D6D9 RID: 55001 RVA: 0x001F97AC File Offset: 0x001F79AC
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

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x0600D6DA RID: 55002 RVA: 0x001F97B5 File Offset: 0x001F79B5
		// (set) Token: 0x0600D6DB RID: 55003 RVA: 0x001F97CE File Offset: 0x001F79CE
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

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0600D6DC RID: 55004 RVA: 0x001F97E5 File Offset: 0x001F79E5
		// (set) Token: 0x0600D6DD RID: 55005 RVA: 0x001F97FD File Offset: 0x001F79FD
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

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x0600D6DE RID: 55006 RVA: 0x001F9813 File Offset: 0x001F7A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkRequest.ParamsOneofCase ParamsCase
		{
			get
			{
				return this.paramsCase_;
			}
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x001F981B File Offset: 0x001F7A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearParams()
		{
			this.paramsCase_ = MapMarkRequest.ParamsOneofCase.None;
			this.params_ = null;
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x001F982B File Offset: 0x001F7A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkRequest);
		}

		// Token: 0x0600D6E1 RID: 55009 RVA: 0x001F983C File Offset: 0x001F7A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MarkPointRequestInfo, other.MarkPointRequestInfo) && object.Equals(this.TemporaryTeleportParam, other.TemporaryTeleportParam) && object.Equals(this.TreasureBoxParam, other.TreasureBoxParam) && this.ParamsCase == other.ParamsCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6E2 RID: 55010 RVA: 0x001F98B4 File Offset: 0x001F7AB4
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

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x001F9928 File Offset: 0x001F7B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6E4 RID: 55012 RVA: 0x001F9935 File Offset: 0x001F7B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6E5 RID: 55013 RVA: 0x001F9940 File Offset: 0x001F7B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TreasureBoxParam);
			}
			if (this.markPointRequestInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MarkPointRequestInfo);
			}
			if (this.paramsCase_ == MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TemporaryTeleportParam);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6E6 RID: 55014 RVA: 0x001F99B8 File Offset: 0x001F7BB8
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

		// Token: 0x0600D6E7 RID: 55015 RVA: 0x001F9A2C File Offset: 0x001F7C2C
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
			if (paramsCase != MapMarkRequest.ParamsOneofCase.TreasureBoxParam)
			{
				if (paramsCase == MapMarkRequest.ParamsOneofCase.TemporaryTeleportParam)
				{
					if (this.TemporaryTeleportParam == null)
					{
						this.TemporaryTeleportParam = new TemporaryTeleportParam();
					}
					this.TemporaryTeleportParam.MergeFrom(other.TemporaryTeleportParam);
				}
			}
			else
			{
				if (this.TreasureBoxParam == null)
				{
					this.TreasureBoxParam = new TreasureBoxParam();
				}
				this.TreasureBoxParam.MergeFrom(other.TreasureBoxParam);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6E8 RID: 55016 RVA: 0x001F9ADA File Offset: 0x001F7CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6E9 RID: 55017 RVA: 0x001F9AE4 File Offset: 0x001F7CE4
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
				if (num != 50U)
				{
					if (num != 82U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
		}

		// Token: 0x040059C1 RID: 22977
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059C2 RID: 22978
		public const int MarkPointRequestInfoFieldNumber = 10;

		// Token: 0x040059C3 RID: 22979
		private MarkPointRequestInfo markPointRequestInfo_;

		// Token: 0x040059C4 RID: 22980
		public const int TemporaryTeleportParamFieldNumber = 12;

		// Token: 0x040059C5 RID: 22981
		public const int TreasureBoxParamFieldNumber = 6;

		// Token: 0x040059C6 RID: 22982
		private object params_;

		// Token: 0x040059C7 RID: 22983
		private MapMarkRequest.ParamsOneofCase paramsCase_;

		// Token: 0x02001829 RID: 6185
		public enum ParamsOneofCase
		{
			// Token: 0x0400C7EE RID: 51182
			None,
			// Token: 0x0400C7EF RID: 51183
			TemporaryTeleportParam = 12,
			// Token: 0x0400C7F0 RID: 51184
			TreasureBoxParam = 6
		}
	}
}
